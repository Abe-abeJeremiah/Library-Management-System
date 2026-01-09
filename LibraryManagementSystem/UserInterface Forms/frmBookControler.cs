using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmBookControler : Form
    {
        private Book _currentBook;

        public int BookID => _currentBook?.BookID ?? 0;

        public frmBookControler()
        {
            InitializeComponent();
        }

        public void SetData(Book book)
        {
            if (book == null) return;

            _currentBook = book;

            lblTitle.Text = book.Title;
            lblSubTitle.Text = string.IsNullOrEmpty(book.SubTitle) ? "" : book.SubTitle;
            lblAuthor.Text = $"Author: {book.Author}";
            lblPages.Text = $"Pages: {book.Pages}";
            lblISBN.Text = $"ISBN: {book.ISBN}";
            lblLocation.Text = $"Location: {book.Location}";
            lblEditor.Text = $"Editor: {book.Editor}";
            lblAccessionNumber.Text = $"Accession #: {book.AccessionNumber}";
            lblPhysicalDescripton.Text = book.PhysicalDescription ?? "";
            lblPublisher.Text = book.Publisher;
            lblPublicationYear.Text = book.PublicationYear.ToString();
            lblEdition.Text = book.Edition;
            lblLanguage.Text = book.Language;
            lblCategory.Text = book.Category ?? "";

            LoadBookImage(book.BookImagePath);
        }

        private void LoadBookImage(string imagePath)
        {
            try
            {
                pctBook.Image?.Dispose();
                pctBook.Image = null;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pctBook.Image = Image.FromStream(fs);
                    }

                }
                else
                {
                     pctBook.Image = Properties.Resources.book; // default image
                }
            }
            catch
            {
                  pctBook.Image = Properties.Resources.book;
            }
        }


        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Borrow Book ID: {BookID}", "Borrow");
            // call Borrow logic here
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Reserve Book ID: {BookID}", "Reserve");
            // call Reserve logic here
        }

        private void pctBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblTitle.Text, "Book Details");
        }
        private void pnlBookDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}
