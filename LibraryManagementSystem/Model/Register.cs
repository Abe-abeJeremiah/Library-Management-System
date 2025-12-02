using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Register
    {
 
        public class RegisteredUser : Users
        {
            public DateTime RegistrationDate { get; set; }

            public RegisteredUser()
            {

                // Automatically set registration date
                this.RegistrationDate = DateTime.Now;
            }
        }

        public class SaveUserLogic
        {
            private UserRepository repo = new UserRepository();

            public void SaveUser(RegisteredUser user)
            {
                // Add user to the repository (or database)
                repo.AddUser(user);

                Console.WriteLine($"Saving User: {user.FirstName} {user.LastName} (ID: {user.UserID})");
            }
        }

    }
}
