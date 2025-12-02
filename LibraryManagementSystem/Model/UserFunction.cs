using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class UserFunction : Users
    {
        public class UserPrivilege
        {
            public static string Privileges(string MemberType)
            {
                switch (MemberType.ToLower())
                {
                    case "Faculty":
                        return "Full Access";
                    case "Staff":
                        return "Manage Books and Members";
                    case "Student":
                        return "Borrow Books";
                    case "Guest":
                        return "View Books";
                    default:
                        return "No Access";
                }
            }

        }

        public class MemberStatus : Users
        {
            public static string Status(DateTime RegistrationDate)
            {
                TimeSpan difference = DateTime.Now - RegistrationDate;

                if (difference.TotalDays >= 100)
                {
                    return "Inactive";
                }
                else
                {
                    return "Active";
                }
            }
        }

    }
}
