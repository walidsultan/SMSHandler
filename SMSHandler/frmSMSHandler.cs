using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using SMSServer.DataMapping;
using SMSServer.DataAccessLayer;
using GSMcommunicator;
using System.Text.RegularExpressions;
namespace SMSServer
{
    public partial class frmSMSHandler : Form
    {
        SmsOutManager _SmsOutManager = new SmsOutManager();
        SMSInManager _SmsInManager = new SMSInManager();
        GSMLine _GsmLine = null;
        int _ReceivedSMSCount = 0;
        int _SentSMSCount = 0;
        int? _MobileMessagesCount = 0;
        public frmSMSHandler()
        {
            InitializeComponent();
        }

        private void frmSMSHandler_Load(object sender, EventArgs e)
        {
            lblCurrentCredit.Text = Settings.CurrentCredit;
            lblSentSms.Text = _SentSMSCount.ToString();
            lblReceivedSms.Text = _ReceivedSMSCount.ToString();
            try
            {
                _GsmLine = new GSMLine(Settings.Com);
                _MobileMessagesCount = _GsmLine.GetMessagesCount();
                if (_MobileMessagesCount.HasValue)
                {
                    //Get all unread messages
                    List<ReceivedMessageData> lstMessages = _GsmLine.ReadMessages(ReceivedMessageStatus.ReceivedUnread);
                    foreach (ReceivedMessageData message in lstMessages)
                    {
                        HandleReceivedMessage(message);
                        if (message.MessageType == ReceivedMessageType.SMS)
                        {
                            _ReceivedSMSCount++;
                        }
                        lblReceivedSms.Text = _ReceivedSMSCount.ToString();
                    }

                    tReceiveSMS.Enabled = true;
                    tSendSMS.Enabled = true;
                }
                else
                {
                    lblResult.Text = "No response from " + Settings.Com;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
                tSendSMS.Enabled = false;
                tReceiveSMS.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentCredit = Microsoft.VisualBasic.Interaction.InputBox("Set the current credit", "Set Credit", Settings.CurrentCredit, this.Left, this.Top);

            double doubleValue = 0;
            if (currentCredit != string.Empty && double.TryParse(currentCredit, out doubleValue))
            {
                AppConfigHandler.WriteSetting("CurrentCredit", currentCredit);
                Settings.CurrentCredit = currentCredit;
                lblCurrentCredit.Text = Settings.CurrentCredit;
                if (doubleValue >double.Parse( Settings.CreditStopLimit ))
                {
                    lblResult.Text = string.Empty;
                }
            }
        }

        private void tSendSMS_Tick(object sender, EventArgs e)
        {
            if (double.Parse(Settings.CurrentCredit) > double.Parse(Settings.CreditStopLimit))
            {
                List<SMSOut> lstUnprocessedSMS = _SmsOutManager.GetSMSOutByStatusAndDestinations(SMSOutStatus.NotProcessed,Settings.Destinations);
                bool sentSMS = false;
                foreach (SMSOut sms in lstUnprocessedSMS)
                {
                    int? mrNumber = _GsmLine.SendSMS(sms.MsgBody, sms.Phone.Trim().Replace("+", ""));
                    if (mrNumber.HasValue)
                    {
                        sms.Status = (int)SMSOutStatus.WithNetwork;
                        sms.MR = mrNumber;
                        sms.Time = DateTime.Now;
                        _SmsOutManager.UpdateSMSOut(sms);

                        //Update SMS Sent Counter
                        _SentSMSCount++;
                        lblSentSms.Text = _SentSMSCount.ToString();

                        //Update the line credit
                        double smsCost = double.Parse(Settings.SMSCost);
                        Settings.CurrentCredit = (double.Parse(Settings.CurrentCredit) - smsCost).ToString();
                        sentSMS = true;
                    }
                }
                if (sentSMS)
                {
                    AppConfigHandler.WriteSetting("CurrentCredit", Settings.CurrentCredit);
                    lblCurrentCredit.Text = Settings.CurrentCredit;
                }
            }
            else
            {
                lblResult.Text = "Credit is under limit";
            }
        }

        private void frmSMSHandler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tReceiveSMS_Tick(object sender, EventArgs e)
        {
            int? currentMessagesCount = _GsmLine.GetMessagesCount();
            if (currentMessagesCount.HasValue)
            {
                if (currentMessagesCount > _MobileMessagesCount)
                {
                    //Get all unread messages
                    List<ReceivedMessageData> lstMessages = _GsmLine.ReadMessages(ReceivedMessageStatus.ReceivedUnread);
                    foreach (ReceivedMessageData message in lstMessages)
                    {
                        HandleReceivedMessage(message);
                        if (message.MessageType == ReceivedMessageType.SMS)
                        {
                            _ReceivedSMSCount++;
                        }
                    }

                    _MobileMessagesCount = currentMessagesCount;

                    lblReceivedSms.Text = _ReceivedSMSCount.ToString();
                }
                if (currentMessagesCount.Value > int.Parse(Settings.SMSDeleteThreshold) && Settings.DisableAutoDelete == false)
                {
                    DeleteOverflowedSMS();
                }
            }


        }

        private void HandleReceivedMessage(ReceivedMessageData sms)
        {
            if (sms.MessageType == ReceivedMessageType.SMS)
            {
                //if the sender number is text then ignore the sent message 
                Match regexMatch= Regex.Match(sms.SenderNumber,"\\d");
                if (!regexMatch.Success) return;

                SMSIn smsIn = new SMSIn();
                smsIn.MsgBody = sms.MessageContent;
                smsIn.Phone = "+" + sms.SenderNumber;
                smsIn.RecTime = DateTime.Now;
                smsIn.Status = 0;
                _SmsInManager.InsertSmsIn(smsIn);
            }
            else if (sms.MessageType == ReceivedMessageType.StatusReport)
            {
                SMSOut smsOut = _SmsOutManager.GetSMSOutByMr(sms.MRNumber.Value);
                
                //If the message sent directly from the mobile and wasn't saved in the database
                if (smsOut == null) return;

                switch (sms.SMSStatus.Value)
                {
                    case SMSStatus.NoResponseFromSME:
                        smsOut.Status = (int)SMSOutStatus.NoResponse;
                        break;
                    case SMSStatus.NotSend:
                        smsOut.Status = (int)SMSOutStatus.Failed;
                        break;
                    case SMSStatus.Success:
                        smsOut.Status = (int)SMSOutStatus.Delivered;
                        break;
                }
                smsOut.Time = DateTime.Now;
                _SmsOutManager.UpdateSMSOut(smsOut);
            }
        }

        private void DeleteOverflowedSMS()
        {
            try
            {
                int smsDeleteThreshold = int.Parse(Settings.SMSDeleteThreshold);
                int countDelete = 0;
                for (int messageIndex = 1; messageIndex < 256; messageIndex++)
                {
                    int? messageCountBeforeDeleting = _GsmLine.GetMessagesCount();
                    bool isMessageDeleted= _GsmLine.DeleteMessageById(messageIndex);
                    int? messageCountAfterDeleting = _GsmLine.GetMessagesCount();
                    if(messageCountBeforeDeleting.HasValue && messageCountAfterDeleting .HasValue && isMessageDeleted && messageCountAfterDeleting.Value<messageCountBeforeDeleting.Value)
                    {
                        countDelete++;
                        _MobileMessagesCount--;
                    }
                    if (countDelete >= (_MobileMessagesCount - smsDeleteThreshold))
                    {
                        break;
                    }
                }
            }
            catch
            {
            }
        }

        private void disableAutoDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableAutoDeleteToolStripMenuItem.Text == "Disable Auto Delete")
            {
                Settings.DisableAutoDelete = true;
                disableAutoDeleteToolStripMenuItem.Text = "Enable Auto Delete";
            }
            else
            {
                Settings.DisableAutoDelete = false;
                disableAutoDeleteToolStripMenuItem.Text = "Disable Auto Delete";
            }
        }
    }
}
