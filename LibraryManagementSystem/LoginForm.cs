using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;


using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FrmLogin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LMSdb"].ConnectionString;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtboxEmailCredentials.Text.Trim();
            string password = txtboxPasswordCredentials.Text;

            // ===== EMPTY CHECK =====
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

           
            if (!email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }


            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
            SELECT role
            FROM dbo.Users
            WHERE email = @email AND password = @password
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string role = dr["role"].ToString();

                        MessageBox.Show($"Login successful! Role: {role}", "Success");

                        UserInterface main = new UserInterface();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                    }
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
    }
}
