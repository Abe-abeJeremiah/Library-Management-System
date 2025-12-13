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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users RegisterUser = new Users
            {

                UserName = txtUserName.Text,

                EmailAddress = txtRegisterEmail.Text,
                MemberType = listRegisterType.SelectedItem.ToString(),
                Password = txtRegisterPassword.Text,
                ConfirmPassword = txtConfimPassword.Text,
                ExpirationDate = DateTime.Now.AddDays(150) //150 days from registration

            };
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Register Complete!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            ); //show if successful register

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }
    }
}
