using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSServer
{
    public class Settings
    {
        public static string CurrentCredit;
        public static string SMSCost;
        public static string SMSDeleteThreshold;
        public static string CreditStopLimit;
        public static string Com;
        public static bool DisableAutoDelete= false;
        public static List<int> Destinations;
    }
}
