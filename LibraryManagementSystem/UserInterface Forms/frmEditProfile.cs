using LibraryManagementSystem.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmEditProfile : Form
    {
        // TEMP: replace later with logged-in user
        private int currentUserId = 1;
        private string imagePath = "";

        public frmEditProfile()
        {
            InitializeComponent();
            LoadUserProfile();
        }

        // ================================
        // LOAD USER DATA
        // ================================
        private void LoadUserProfile()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"SELECT UserName, EmailAddress, Address, Contact, ProfileImagePath
                      FROM Users WHERE UserID=@uid", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox3.Text = dr["UserName"].ToString();
                    textBox1.Text = dr["EmailAddress"].ToString();
                    textBox4.Text = dr["Address"].ToString();
                    textBox5.Text = dr["Contact"].ToString();
                    textBox2.Clear();

                    if (dr["ProfileImagePath"] != DBNull.Value)
                    {
                        imagePath = dr["ProfileImagePath"].ToString();
                        if (File.Exists(imagePath))
                            pictureBox1.Image = Image.FromFile(imagePath);
                    }
                }
            }
        }

        // ================================
        // UPLOAD / REMOVE PHOTO
        // ================================
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                SaveProfileImage();
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imagePath = "";

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET ProfileImagePath=NULL WHERE UserID=@uid", con);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveProfileImage()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET ProfileImagePath=@img WHERE UserID=@uid", con);
                cmd.Parameters.AddWithValue("@img", imagePath);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.ExecuteNonQuery();
            }
        }

        // ================================
        // UPDATE EMAIL (DESIGNER CALLS _Click_1)
        // ================================
        private void btnChangeEmail_Click_1(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox1.Text))
            {
                MessageBox.Show("Invalid email format",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateField("EmailAddress", textBox1.Text);
        }

        // ================================
        // UPDATE PASSWORD
        // ================================
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET PasswordHash=@pwd WHERE UserID=@uid", con);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password updated successfully");
            textBox2.Clear();
        }


        // ================================
        // UPDATE USERNAME
        // ================================
        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }

            UpdateField("UserName", textBox3.Text);
        }

        // ================================
        // UPDATE ADDRESS
        // ================================
        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            UpdateField("Address", textBox4.Text);
        }

        // ================================
        // UPDATE CONTACT
        // ================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidContact(textBox5.Text))
            {
                MessageBox.Show(
                    "Invalid contact number\nFormat: 09XXXXXXXXX or +639XXXXXXXXX",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            UpdateField("Contact", textBox5.Text);
        }

        // ================================
        // REUSABLE DB UPDATE
        // ================================
        private void UpdateField(string column, string value)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    $"UPDATE Users SET {column}=@val WHERE UserID=@uid", con);
                cmd.Parameters.AddWithValue("@val", value);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"{column} updated successfully");
        }

        // ================================
        // VALIDATION
        // ================================
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidContact(string contact)
        {
            return Regex.IsMatch(contact, @"^(09|\+639)\d{9}$");
        }

        // ================================
        // SAFE UNUSED EVENTS
        // ================================
        private void label14_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
    }
}
