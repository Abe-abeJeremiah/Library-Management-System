using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LibraryManagementSystem.UserInterface_Forms;

namespace LibraryManagementSystem
{
    public partial class UserInterface : Form
    {
        // List to hold all navigation buttons
        private List<Button> navigationButtons = new List<Button>();

        // Colors for button states (adjust as needed)
        private readonly Color NormalColor = Color.FromArgb(24, 30, 54);
        private readonly Color ActiveColor = Color.FromArgb(46, 51, 73);

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        public UserInterface()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ButtonChecker();
            LoadChildForm(new frmDashboard(), "Dashboard");
        }

        private void LoadChildForm(Form childForm, string title)
        {
            lblTitle.Text = title;

            this.PnlFormLoader.Controls.Clear();

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None; // Ensure the child form is borderless

            this.PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        // ... rest of the code including ButtonChecker()

        private void ButtonChecker()
        {
            if (btnDashboard != null) navigationButtons.Add(btnDashboard);
            if (btnBooks != null) navigationButtons.Add(btnBooks);
            if (btnFines != null) navigationButtons.Add(btnFines);
            if (btnHistory != null) navigationButtons.Add(btnHistory);
            if (btnEditProfile != null) navigationButtons.Add(btnEditProfile);
        }

        // Resets all navigation buttons to the normal color
        private void ResetButtons()
        {
            if (navigationButtons == null) return; // Safety check
            foreach (Button btn in navigationButtons)
            {
                if (btn != null)
                {
                    btn.BackColor = NormalColor;
                }
            }
        }

        // Activates the specified button: resets all, moves the nav panel, and highlights the button
        private void ActivateButton(Button btn)
        {
            if (btn == null) return; // Safety check
            ResetButtons(); // Reset all buttons first

            // Move navigation panel to align with the active button if the panel exists
            // The panel is expected to be defined in the designer partial class.
            if (pnlNav != null)
            {
                // Guard against layout quirks
                if (btn.Height > 0) pnlNav.Height = btn.Height;
                pnlNav.Top = btn.Top;
                pnlNav.Left = btn.Left;
            }

            //Highlight the active button
            btn.BackColor = ActiveColor;
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);
            
            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard Frmdashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frmdashboard_vrb);
            Frmdashboard_vrb.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBooks);

            lblTitle.Text = "Books";
            this.PnlFormLoader.Controls.Clear();
            frmBooks FrmBooks_vrb = new frmBooks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmBooks_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmBooks_vrb);
            FrmBooks_vrb.Show();
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            ActivateButton(btnFines);
            lblTitle.Text = "Fines";
            this.PnlFormLoader.Controls.Clear();
            frmFines FrmFines_vrb = new frmFines() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmFines_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmFines_vrb);
            FrmFines_vrb.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHistory);
            lblTitle.Text = "History";
            this.PnlFormLoader.Controls.Clear();
            frmHistory FrmHistory_vrb = new frmHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHistory_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHistory_vrb);
            FrmHistory_vrb.Show();

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close(); // closes ONLY UserInterface
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEditProfile);
            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmEditProfile FrmSettings_vrb = new frmEditProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmSettings_vrb);
            FrmSettings_vrb.Show();
        }
    }
}
