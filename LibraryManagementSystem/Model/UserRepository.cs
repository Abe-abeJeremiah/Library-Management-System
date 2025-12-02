using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagementSystem.Model.Register;

namespace LibraryManagementSystem.Model
{
    public class UserRepository
    {
        private List<RegisteredUser> users = new List<RegisteredUser>();

        public void AddUser(RegisteredUser user)
        {
            users.Add(user);
        }

        public List<RegisteredUser> GetAllUsers()
        {
            return users;
        }

        public RegisteredUser FindByEmail(string email)
        {
            return users.FirstOrDefault(u => u.EmailAddress == email);
        }
    }

}
