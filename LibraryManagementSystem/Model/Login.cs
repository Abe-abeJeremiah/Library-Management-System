using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Model
{
    internal class Login
    {
        private UserRepository userRepo = new UserRepository();

        public bool LoginUser(string email, string password)
        {
            // Step 1: Check if user exists
            var user = userRepo.FindByEmail(email);

            if (user == null)
            {
                MessageBox.Show("Email not found.");
                return false;
            }

            // Step 2: Check password
            if (user.Password != password)
            {
                MessageBox.Show("Incorrect password.");
                return false;
            }

            // Step 3: Success
            MessageBox.Show("Login successful!");
            return true;
        }
    }
}
