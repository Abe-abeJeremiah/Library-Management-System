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
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace LibraryManagementSystem
{
    public partial class frmRegister : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LMSdb"].ConnectionString;

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
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text;
            string role = listRegisterType.SelectedItem?.ToString();

            
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                role == null)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            username = char.ToUpper(username[0]) + username.Substring(1);
            txtUserName.Text = username;

            // ===== EMAIL VALIDATION =====
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email must contain '@'");
                return;
            }

            // ===== PASSWORD VALIDATION =====
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // ===== CHECK DUPLICATE USERNAME =====
                string checkUser = "SELECT COUNT(*) FROM dbo.Users WHERE username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkUser, con))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }
                }

                // ===== INSERT USER =====
                string insertQuery = @"
            INSERT INTO dbo.Users (username, email, password, role)
            VALUES (@username, @email, @password, @role)
        ";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!");

                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
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
    }
}
