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

            ApplyRoundedCorners();

            // Add designer controls to navigation list only if they exist
            // (defensive to avoid null reference if designer is changed)
            if (btnDashboard != null) navigationButtons.Add(btnDashboard);
            if (btnBooks != null) navigationButtons.Add(btnBooks);
            if (btnFines != null) navigationButtons.Add(btnFines);
            if (btnHistory != null) navigationButtons.Add(btnHistory);
            if (btnSettings != null) navigationButtons.Add(btnSettings);

            // Default navigation state - only if dashboard button exists
            if (btnDashboard != null)
            {
                ActivateButton(btnDashboard);
            }
        }

        private void ApplyRoundedCorners()
        {
            // Ensure we have a valid size before creating region
            if (Width <= 0 || Height <= 0) return;

            IntPtr regionHandle = CreateRoundRectRgn(0, 0, Width, Height, 25, 25);
            try
            {
                Region = Region.FromHrgn(regionHandle);
            }
            finally
            {
                DeleteObject(regionHandle);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ApplyRoundedCorners();
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

            // Highlight the active button
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
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBooks);
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            ActivateButton(btnFines);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHistory);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSettings);
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
    }
}
