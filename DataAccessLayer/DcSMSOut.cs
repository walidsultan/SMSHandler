using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMSServer.DataMapping;
using System.Configuration;

namespace SMSServer.DataAccessLayer
{
    public class DcSMSOut : SMSOutDataContext 
    {
        public DcSMSOut()
        {
            this.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;
        }
    }
}
