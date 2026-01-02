using System;

namespace LibraryManagementSystem.Model
{
    public static class UserFunction
    {
        public static string GetPrivilege(string memberType)
        {
            switch (memberType.ToLower())
            {
                case "faculty": return "Full Access";
                case "staff": return "Manage Books and Members";
                case "student": return "Borrow Books";
                case "guest": return "View Books";
                default: return "No Access";
            }
        }

        public static string GetStatus(DateTime registrationDate)
        {
            return (DateTime.Now - registrationDate).TotalDays >= 100
                ? "Inactive"
                : "Active";
        }
    }
}
