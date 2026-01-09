using LibraryManagementSystem.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmEditProfile : Form
    {
        private int currentUserId;
        private string imagePath = "";
        private string originalUserName;
        private string originalEmail;
        private string originalAddress;
        private string originalContact;
        private string originalImagePath;


        public frmEditProfile()
        {
            InitializeComponent();
            currentUserId = LoggedInUser.UserID;
          

            // Layout fixes
            textBox1.Multiline = false;
            textBox2.Multiline = false;
            textBox3.Multiline = false;
            textBox5.Multiline = false;
            textBox4.Multiline = true;

            LoadUserProfile();
        }




        // ================================
        // LOAD USER PROFILE (READ ONLY)
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

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return;

                    // 🔒 Store ORIGINAL values for change detection
                    originalUserName = dr["UserName"]?.ToString() ?? "";
                    originalEmail = dr["EmailAddress"]?.ToString() ?? "";
                    originalAddress = dr["Address"]?.ToString() ?? "";
                    originalContact = dr["Contact"]?.ToString() ?? "";
                    originalImagePath = dr["ProfileImagePath"] == DBNull.Value? "" : dr["ProfileImagePath"].ToString();

                    // Username
                    if (string.IsNullOrWhiteSpace(dr["UserName"]?.ToString()))
                        SetPlaceholder(textBox3, "Enter username");
                    else
                    {
                        textBox3.Text = dr["UserName"].ToString();
                        textBox3.ForeColor = Color.Black;
                    }

                    // Email
                    if (string.IsNullOrWhiteSpace(dr["EmailAddress"]?.ToString()))
                        SetPlaceholder(textBox1, "example@email.com");
                    else
                    {
                        textBox1.Text = dr["EmailAddress"].ToString();
                        textBox1.ForeColor = Color.Black;
                    }

                    // Address
                    if (string.IsNullOrWhiteSpace(dr["Address"]?.ToString()))
                        SetPlaceholder(textBox4, "Enter your address");
                    else
                    {
                        textBox4.Text = dr["Address"].ToString();
                        textBox4.ForeColor = Color.Black;
                    }

                    // Contact
                    if (string.IsNullOrWhiteSpace(dr["Contact"]?.ToString()))
                        SetPlaceholder(textBox5, "09XXXXXXXXX");
                    else
                    {
                        textBox5.Text = dr["Contact"].ToString();
                        textBox5.ForeColor = Color.Black;
                    }

                    // Password (always placeholder)
                    SetPlaceholder(textBox2, "Enter new password", true);


                    if (dr["ProfileImagePath"] != DBNull.Value)
                    {
                        imagePath = dr["ProfileImagePath"].ToString();
                        LoadImageSafe(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.Screenshot__354_;
                    }
                }
            }
        }

        private void LoadImageSafe(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    pictureBox1.Image = Properties.Resources.Screenshot__354_;
                    return;
                }

                // Dispose old image first
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Screenshot__354_;
            }
        }


        // ================================
        // UPLOAD PHOTO (PREVIEW ONLY)
        // ================================
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            imagePath = ofd.FileName;
            LoadImageSafe(imagePath);
        }

        // ================================
        // REMOVE PHOTO (PREVIEW ONLY)
        // ================================
        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            // Dispose old image to avoid file lock crash
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            imagePath = "";
            pictureBox1.Image = Properties.Resources.Screenshot__354_;
        }


        // ================================
        // CHANGE PASSWORD (DIRECT, HASHED)
        // ================================
        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            string password = textBox2.Text.Trim();

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET PasswordHash=@pwd WHERE UserID=@uid", con);
                cmd.Parameters.AddWithValue("@pwd", hashedPassword);
                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password updated successfully");
            textBox2.Clear();
        }

        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // ================================
        // VALIDATION BUTTONS (FORM ONLY)
        // ================================
        private void btnChangeEmail_Click_1(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox1.Text))
                MessageBox.Show("Invalid email format");
        }

        private void btnChangeUserName_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
                MessageBox.Show("Username cannot be empty");
        }

        private void btnChangeAddress_Click_1(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!IsValidContact(textBox5.Text))
                MessageBox.Show("Invalid contact number");
        }

        // ================================
        // SUBMIT PROFILE UPDATE REQUEST
        // (ADMIN APPROVAL REQUIRED)
        // ================================
        private void button2_Click(object sender, EventArgs e)
        {
            // 🧠 Check if ANYTHING changed
            bool hasChanges =
                (textBox3.ForeColor != Color.Gray && textBox3.Text != originalUserName) ||
                (textBox1.ForeColor != Color.Gray && textBox1.Text != originalEmail) ||
                (textBox4.ForeColor != Color.Gray && textBox4.Text != originalAddress) ||
                (textBox5.ForeColor != Color.Gray && textBox5.Text != originalContact) ||
                imagePath != originalImagePath;

            if (!hasChanges)
            {
                MessageBox.Show(
                    "No changes detected.\nPlease update at least one field before submitting.",
                    "Nothing to Submit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO ProfileUpdateRequests
              (UserID, NewUserName, NewEmail, NewAddress, NewContact, NewProfileImagePath)
              VALUES
              (@uid, @uname, @email, @address, @contact, @img)", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);
                cmd.Parameters.AddWithValue("@uname", textBox3.ForeColor == Color.Gray ? (object)DBNull.Value : textBox3.Text);
                cmd.Parameters.AddWithValue("@email", textBox1.ForeColor == Color.Gray ? (object)DBNull.Value : textBox1.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.ForeColor == Color.Gray ? (object)DBNull.Value : textBox4.Text);
                cmd.Parameters.AddWithValue("@contact", textBox5.ForeColor == Color.Gray ? (object)DBNull.Value : textBox5.Text);
                cmd.Parameters.AddWithValue("@img", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                "Your profile update request has been submitted.\nPlease wait for admin approval.",
                "Request Sent",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
        // UNUSED SAFE EVENTS
        // ================================
        private void label14_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void SetPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            if (isPassword)
                tb.UseSystemPasswordChar = false;

            tb.Enter += (s, e) =>
            {
                if (tb.ForeColor == Color.Gray)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;

                    if (isPassword)
                        tb.UseSystemPasswordChar = true;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;

                    if (isPassword)
                        tb.UseSystemPasswordChar = false;
                }
            };
        }

    }
}
