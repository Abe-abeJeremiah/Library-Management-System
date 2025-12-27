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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
            LoadBookCards();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadBookCards()
        {
            tblBooks.Controls.Clear();
            tblBooks.RowStyles.Clear();
            tblBooks.RowCount = 0;

            int col = 0;
            int row = 0;

            // SAMPLE LOOP (replace with SQL later)
            for (int i = 0; i < 6; i++)
            {
                frmBookControler bookCard = new frmBookControler();

                bookCard.SetData(
                    $"Book Title {i + 1}",
                    $"Author {i + 1}",
                    $"ISBN-{i + 1000}"
                );

                bookCard.Dock = DockStyle.Fill;

                if (col == 0)
                {
                    tblBooks.RowCount++;
                    tblBooks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                tblBooks.Controls.Add(bookCard, col, row);

                col++;
                if (col == 2)
                {
                    col = 0;
                    row++;
                }
            }
        }

        private void tblBooks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

