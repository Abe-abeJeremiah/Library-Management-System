using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;


namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            LoadBookCards();
        }

        private void LoadBookCards()
        {
            tblBooks.Controls.Clear();
            tblBooks.RowStyles.Clear();
            tblBooks.RowCount = 0;

            int col = 0;
            int row = 0;

            BookRepository repo = new BookRepository();
            List<LibraryBook> books = repo.GetAllBooks(); // ✅ CORRECT MODEL

            foreach (LibraryBook book in books)
            {
                frmBookControler bookCard = new frmBookControler();
                bookCard.TopLevel = false;
                bookCard.FormBorderStyle = FormBorderStyle.None;
                bookCard.Dock = DockStyle.Fill;

                bookCard.SetData(book);
                bookCard.Show();

                if (col == 0)
                {
                    tblBooks.RowCount++;
                    tblBooks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                tblBooks.Controls.Add(bookCard, col, row);

                col++;
                if (col >= 2)
                {
                    col = 0;
                    row++;
                }
            }
        }

        
        private void tblBooks_Paint(object sender, PaintEventArgs e)
        {
            // optional custom drawing
        }

    }
}
