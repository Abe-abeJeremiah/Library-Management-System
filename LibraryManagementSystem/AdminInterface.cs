using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem
{
    public partial class AdminInterface : Form
    {
        // Optional: keep default constructor if designer complains
        public AdminInterface()
        {
            InitializeComponent();
            // Designer-friendly; no logged-in user supplied
            LoggedInUser = null;
        }

        // Overload to allow passing the current logged-in user instance
        public AdminInterface(dynamic loggedInUser) : this()
        {
            LoggedInUser = loggedInUser;
        }

        // Instance property (dynamic) to shadow any type named LoggedInUser and hold the current user
        private dynamic LoggedInUser { get; set; }

        // ✅ load username, role, and profile image
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            // Safe access: if no user supplied, show defaults
            var user = LoggedInUser;
            if (user == null)
            {
                lblUserName.Text = string.Empty;
                lblRole.Text = string.Empty;
                LoadProfileImage(null);
                return;
            }

            // Use dynamic properties with fallback to avoid runtime exceptions if properties missing or null
            try
            {
                lblUserName.Text = user.UserName ?? string.Empty;
            }
            catch
            {
                lblUserName.Text = string.Empty;
            }

            try
            {
                lblRole.Text = user.Role ?? string.Empty;
            }
            catch
            {
                lblRole.Text = string.Empty;
            }

            string profileImagePath = null;
            try
            {
                profileImagePath = user.ProfileImagePath;
            }
            catch
            {
                profileImagePath = null;
            }

            LoadProfileImage(profileImagePath);
        }


        private void LoadProfileImage(string imagePath)
        {
            try
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = null;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources._487391276_8614531771983355_5210645756945235689_n; 
                }
            }
            catch
            {
                pictureBox1.Image = Properties.Resources._487391276_8614531771983355_5210645756945235689_n;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e) { }
        private void btnBooks_Click(object sender, EventArgs e) { }
        private void btnFines_Click(object sender, EventArgs e) { }
        private void btnHistory_Click(object sender, EventArgs e) { }
        private void btnEditProfile_Click(object sender, EventArgs e) { }
        private void btnRervation_Click(object sender, EventArgs e) { }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void PanelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
