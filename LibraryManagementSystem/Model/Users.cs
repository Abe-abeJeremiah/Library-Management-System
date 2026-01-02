using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public abstract class Users 
    {
         public int UserID { get; set; }
         public string UserName { get; set; }
         public string EmailAddress { get; set; }
         public string MemberType { get; set; }   // matches SQL
         public string PasswordHash { get; set; }
         public DateTime ExpirationDate { get; set; }
         public DateTime RegistrationDate { get; set; }

    }

}
