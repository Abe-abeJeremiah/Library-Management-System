using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FrmLogin : Form
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["LMSdb"].ConnectionString;
        private bool showLoginPassword = false;


        public FrmLogin()
        {
            InitializeComponent();
        }

        // ================= PASSWORD HASHING =================
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtboxEmailCredentials.Text.Trim();
            string password = txtboxPasswordCredentials.Text;

            // ================= VALIDATION =================
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            string hashedPassword = HashPassword(password);

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = @"
                        SELECT UserID, UserName, MemberType, ProfileImagePath, ExpirationDate
                        FROM dbo.Users
                        WHERE EmailAddress = @email
                          AND PasswordHash = @password
                          AND ExpirationDate >= GETDATE()
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = hashedPassword;

                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            LoggedInUser.UserID = Convert.ToInt32(dr["UserID"]);
                            LoggedInUser.UserName = dr["UserName"].ToString();
                            LoggedInUser.Role = dr["MemberType"].ToString();
                            LoggedInUser.ProfileImagePath = dr["ProfileImagePath"] == DBNull.Value
                                ? null
                                : dr["ProfileImagePath"].ToString();

                            MessageBox.Show("Login successful!", "Success");

                            UserInterface main = new UserInterface();
                            main.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show(
                                "Invalid credentials or account expired.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtboxPasswordCredentials.UseSystemPasswordChar = true;
            Pdeye.Image = Properties.Resources.closed_eyes;
        }



        private void lblTitle_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtboxPasswordCredentials_TextChanged(object sender, EventArgs e) { }
        private void txtboxEmailCredentials_TextChanged(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showLoginPassword = !showLoginPassword;

            txtboxPasswordCredentials.UseSystemPasswordChar = !showLoginPassword;

            Pdeye.Image = showLoginPassword
               ? Properties.Resources.eye
                : Properties.Resources.closed_eyes;
        }

    }
}
