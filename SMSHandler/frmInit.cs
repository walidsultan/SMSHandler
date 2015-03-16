using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Reflection;
using SMSServer.DataMapping;
using SMSServer.DataAccessLayer;
using System.Text.RegularExpressions;

namespace SMSServer
{
    public partial class frmInit : Form
    {
        DestinationsManager _DestinationManager = new DestinationsManager();
        public frmInit()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidSettings())
            {
                AppConfigHandler.WriteSetting("CurrentCredit", txtCurrentCredit.Text);
                Settings.CurrentCredit = txtCurrentCredit.Text;
                AppConfigHandler.WriteSetting("SMSCost", txtSMSCost.Text);
                Settings.SMSCost = txtSMSCost.Text;
                AppConfigHandler.WriteSetting("SMSDeleteThreshold", txtSMSDeleteThreshold.Text);
                Settings.SMSDeleteThreshold = txtSMSDeleteThreshold.Text;
                AppConfigHandler.WriteSetting("CreditStopLimit", txtCreditStopLimit.Text);
                Settings.CreditStopLimit = txtCreditStopLimit.Text;
                AppConfigHandler.WriteSetting("Com", txtCom.Text);
                Settings.Com = txtCom.Text;
                frmSMSHandler formSMSHandler = new frmSMSHandler();
                formSMSHandler.Show();
                this.Hide();
            }
        }

        private bool IsValidSettings()
        {
            bool isValid = true;

            epSettings.SetError(txtCreditStopLimit, string.Empty);
            epSettings.SetError(txtCurrentCredit, string.Empty);
            epSettings.SetError(txtSMSCost, string.Empty);
            epSettings.SetError(txtSMSDeleteThreshold, string.Empty);
            epSettings.SetError(txtCom, string.Empty);
            epSettings.SetError(lblSelectedDestinations , string.Empty);

            double doubleValue = 0;
            if (txtCreditStopLimit.Text.Trim() == string.Empty || !double.TryParse(txtCreditStopLimit.Text, out doubleValue))
            {
                isValid = false;
                epSettings.SetError(txtCreditStopLimit, "Invalid Credit Stop Limit");
            }

            if (txtCurrentCredit.Text.Trim() == string.Empty || !double.TryParse(txtCurrentCredit.Text, out doubleValue))
            {
                isValid = false;
                epSettings.SetError(txtCurrentCredit, "Invalid Current Credit");
            }

            if (txtSMSCost.Text.Trim() == string.Empty || !double.TryParse(txtSMSCost.Text, out doubleValue))
            {
                isValid = false;
                epSettings.SetError(txtSMSCost, "Invalid SMS Cost");
            }

            if (txtSMSDeleteThreshold.Text.Trim() == string.Empty || !double.TryParse(txtSMSDeleteThreshold.Text, out doubleValue))
            {
                isValid = false;
                epSettings.SetError(txtSMSDeleteThreshold, "Invalid SMS Delete Threshold");
            }

            if (txtSMSDeleteThreshold.Text.Trim() == string.Empty)
            {
                isValid = false;
                epSettings.SetError(txtCom, "Invalid COM Number");
            }


            if (lblSelectedDestinations.Text  == string.Empty )
            {
                isValid = false;
                epSettings.SetError(lblSelectedDestinations, "Select one destination at least");
            }
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInit_Load(object sender, EventArgs e)
        {
            txtCurrentCredit.Text = ConfigurationManager.AppSettings["CurrentCredit"].ToString();
            txtSMSCost.Text = ConfigurationManager.AppSettings["SMSCost"].ToString();
            txtSMSDeleteThreshold.Text = ConfigurationManager.AppSettings["SMSDeleteThreshold"].ToString();
            txtCreditStopLimit.Text = ConfigurationManager.AppSettings["CreditStopLimit"].ToString();
            txtCom.Text = ConfigurationManager.AppSettings["Com"].ToString();
            InitializeDestinations();
        }

        private void InitializeDestinations()
        {
            List<string> lstDestinations = Regex.Split(ConfigurationManager.AppSettings["Destinations"].ToString(), ",").ToList();
            List<int> lstDestinationsIds = new List<int>();
            foreach (string destinationId in lstDestinations)
            {
                Destination destination = _DestinationManager.GetDestinationById(int.Parse(destinationId));
                if (destination != null)
                {
                    if (lblSelectedDestinations.Text == string.Empty)
                    {
                        lblSelectedDestinations.Text = destination.Name;
                    }
                    else
                    {
                        lblSelectedDestinations.Text += ", " + destination.Name;
                    }
                    lstDestinationsIds.Add(int.Parse(destinationId));
                }
            }
            Settings.Destinations = lstDestinationsIds;
            if (lblSelectedDestinations.Text.Length  > 20)
            {
                lblSelectedDestinations.Text = lblSelectedDestinations.Text.Substring(0, 20) + "...";
            }
            lnkEditDestinations.Left = lblSelectedDestinations.Left + lblSelectedDestinations.Width + 10;
        }

        private void lnkEditDestinations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDestinations formDestinations = new frmDestinations();
            formDestinations.DestinationsSelected += new frmDestinations.DestinationsSelectedHandler(formDestinations_DestinationsSelected);
            formDestinations.ShowDialog();
        }

        void formDestinations_DestinationsSelected(object sender, EventArgs e)
        {
            lblSelectedDestinations.Text = string.Empty;
            foreach (int destinationId in Settings.Destinations )
            {
                Destination destination = _DestinationManager.GetDestinationById(destinationId);
                if (destination != null)
                {
                    if (lblSelectedDestinations.Text == string.Empty)
                    {
                        lblSelectedDestinations.Text = destination.Name;
                    }
                    else
                    {
                        lblSelectedDestinations.Text += ", " + destination.Name;
                    }
                }
            }
            lnkEditDestinations.Left = lblSelectedDestinations.Left + lblSelectedDestinations.Width + 10;
        }


    }
}
