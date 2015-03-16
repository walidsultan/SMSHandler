using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMSServer.DataMapping;

namespace SMSServer.DataAccessLayer
{
    public class SMSInManager
    {
        public int InsertSmsIn(SMSIn  smsIn)
        {
            DcSMSOut dbSMS = new DcSMSOut();
            dbSMS.SMSIns .InsertOnSubmit(smsIn);
            dbSMS.SubmitChanges();
            return smsIn.Id;
        }
    }
}
