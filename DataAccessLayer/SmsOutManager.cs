using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMSServer.DataMapping;

namespace SMSServer.DataAccessLayer
{
    public class SmsOutManager 
    {
        public List<SMSOut> GetSMSOutByStatusAndDestinations(SMSOutStatus  status,List<int> lstDestinations)
        {
            DcSMSOut dbSMS = new DcSMSOut();
            return dbSMS.SMSOuts.Where(s => s.Status == (int)status && lstDestinations.Contains(s.DestinationId.Value)).ToList();
        }

        public SMSOut GetSMSOutByMr(int mr)
        {
            DcSMSOut dbSMS = new DcSMSOut();
            return dbSMS.SMSOuts.Where(s => s.MR.Value  == mr ).SingleOrDefault();
        }
        public void UpdateSMSOut(SMSOut  smsOut)
        {
            DcSMSOut dbSMS = new DcSMSOut();
            SMSOut exisitingSMSOut = dbSMS.SMSOuts.SingleOrDefault(s => s.Id == smsOut.Id);
            exisitingSMSOut.MsgBody = smsOut.MsgBody;
            exisitingSMSOut.Phone = smsOut.Phone;
            exisitingSMSOut.Status = smsOut.Status;
            exisitingSMSOut.MR = smsOut.MR;
            exisitingSMSOut.Time = smsOut.Time;
            dbSMS.SubmitChanges();
        }
    }
}
