using LibraryManagementSystem.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem
{
    public partial class frmRegister : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LMSdb"].ConnectionString;
        private bool showPass = false;
        private bool showConfirm = false;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtRegisterPassword.UseSystemPasswordChar = true;
            picEyePassword.Image = Properties.Resources.closed_eyes;
        }


        // ===== PASSWORD HASHING =====
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text;
            string role = cmbxRegisterType.SelectedItem?.ToString();

            // ===== EMPTY CHECK =====
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                role == null)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // Capitalize username
            username = char.ToUpper(username[0]) + username.Substring(1);
            txtUserName.Text = username;

            // ===== EMAIL VALIDATION =====
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format");
                return;
            }

            // ===== PASSWORD VALIDATION =====
            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            string hashedPassword = HashPassword(password);

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // ===== CHECK DUPLICATE USERNAME =====
                    string checkUser = "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @username";

                    using (SqlCommand cmdUser = new SqlCommand(checkUser, con))
                    {
                        cmdUser.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        if ((int)cmdUser.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Username already exists.");
                            return;
                        }
                    }

                    // ===== CHECK DUPLICATE EMAIL =====
                    string checkEmail = "SELECT COUNT(*) FROM dbo.Users WHERE EmailAddress = @email";

                    using (SqlCommand cmdEmail = new SqlCommand(checkEmail, con))
                    {
                        cmdEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                        if ((int)cmdEmail.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Email already registered.");
                            return;
                        }
                    }

                    // ===== INSERT USER =====
                    string insertQuery = @"
INSERT INTO dbo.Users
(UserName, EmailAddress, PasswordHash, MemberType, ExpirationDate, RegistrationDate)
VALUES
(@username, @email, @password, @role,
 DATEADD(YEAR, 1, GETDATE()),
 GETDATE())";



                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = hashedPassword;
                        cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!");

                    FrmLogin login = new FrmLogin();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void cmbxRegisterType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void picEyePassword_Click(object sender, EventArgs e)
        {
            showPass = !showPass;
            txtRegisterPassword.UseSystemPasswordChar = !showPass;

            picEyePassword.Image = showPass
                ? Properties.Resources.eye
                : Properties.Resources.closed_eyes;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             showConfirm = !showConfirm;
            txtConfimPassword.UseSystemPasswordChar = !showConfirm;

            picEyeConfirmPassword.Image = showConfirm
                ? Properties.Resources.eye
                : Properties.Resources.closed_eyes;
        }
    }
    }
