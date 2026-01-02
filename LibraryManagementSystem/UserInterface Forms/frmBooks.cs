using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Model;

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

            BookRepository repo = new BookRepository();
            List<LibraryBook> books = repo.GetAllBooks(); // DB data

            foreach (LibraryBook book in books)
            {
                frmBookControler bookCard = new frmBookControler();
                bookCard.SetData(book);   // ✅ THIS IS THE FIX

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

