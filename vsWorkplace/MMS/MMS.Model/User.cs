using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Model
{
    

    public class User
    {
        public static int userID { get; set; }

        public static string userAccount { get; set; }
        


        public int ID { get; set; }
        public string ACCOUNT { get; set; }
        public string PASSWORD { get; set; }
    }
}
