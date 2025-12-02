using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users RegisterUser = new Users
            {

                FirstName = txtRegisterFirstName.Text,
                LastName = txtRegisterLastName.Text,
                EmailAddress = txtRegisterEmail.Text,
                MemberType = listRegisterType.SelectedItem.ToString(),
                Password = txtRegisterPassword.Text,
                ConfirmPassword = txtConfimPassword.Text,
                ExpirationDate = DateTime.Now.AddDays(150) //150 days from registration

            };
        }
    }
}
