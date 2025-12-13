using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Users 
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string MemberType { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime ExpirationDate { get; set; } 

    }

    


}
