using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
        public static class LoggedInUser
        {
            public static int UserID { get; set; }
            public static string UserName { get; set; }
            public static string Role { get; set; }
            public static string ProfileImagePath { get; set; }
        }
    }

