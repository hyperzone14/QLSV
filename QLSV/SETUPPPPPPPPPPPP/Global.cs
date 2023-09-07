using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Global
    {
        
        public static int GlobalUserID { get; private set; }
        public static string GlobalUsername { get; private set; }
        public static void SetGlobalUserID(int userID)
        {
            GlobalUserID = userID;
        }
        public static void SetGlobalUsername(string userName)
        {
            GlobalUsername = userName;
        }
        
    }
}
