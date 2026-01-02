using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmFines : Form
    {
        public frmFines()
        {
            InitializeComponent();
           
        }


        private void frmFines_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int daysLate;
            decimal finePerDay = 5; // ₱5 per day

            if (int.TryParse(txtDaysLate.Text, out daysLate))
            {
                decimal totalFine = daysLate * finePerDay;
                txtFine.Text = totalFine.ToString("0.00");
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid number of days.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtName.Clear();
            txtDaysLate.Clear();
            txtFine.Clear();
        }

    
private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFine.Text))
            {
                MessageBox.Show("No fine to pay.",
                                "Payment",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Fine paid successfully!",
                            "Payment Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            btnClear_Click(sender, e);
        }

        private void lblBorrowerId_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

