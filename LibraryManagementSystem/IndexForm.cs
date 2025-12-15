using LibraryManagementSystem.Index_Forms;
using LibraryManagementSystem.UserInterface_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadChildForm(new frmHome(), "Home");
        }

        private void LoadChildForm(Form childForm, string title)
        {

            this.pnlIndex.Controls.Clear();

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None; // Ensure the child form is borderless

            this.pnlIndex.Controls.Add(childForm);
            childForm.Show();
        }

       

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlIndex.Controls.Clear();
            frmHome frmHome = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlIndex.Controls.Add(frmHome);
            frmHome.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.pnlIndex.Controls.Clear();
            frmAboutUs frmAboutUs = new frmAboutUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAboutUs.FormBorderStyle = FormBorderStyle.None;
            this.pnlIndex.Controls.Add(frmAboutUs);
            frmAboutUs.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();

            this.Hide();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlIndex_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
