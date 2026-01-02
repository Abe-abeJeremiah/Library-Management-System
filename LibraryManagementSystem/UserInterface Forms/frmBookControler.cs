using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmBookControler : Form
    {
        public frmBookControler()
        {
            InitializeComponent();
        }

        private void pctBook_Click(object sender, EventArgs e)
        {

        }
        public void SetData(Book book)
        {
            if (book == null) return;

            lblTitle.Text = book.Title;
            lblSubTitle.Text = book.SubTitle;
            lblAuthor.Text = book.Author;
            lblPages.Text = book.Pages.ToString();
            lblISBN.Text = book.ISBN;
            lblLocation.Text = book.Location;
            lblEditor.Text = book.Editor;
            lblAccessionNumber.Text = book.AccessionNumber;
            lblPhysicalDescripton.Text = book.PhysicalDescription;
            lblPublisher.Text = book.Publisher;
            lblPublicationYear.Text = book.PublicationYear.ToString();
            lblEdition.Text = book.Edition;
            lblLanguage.Text = book.Language;

            // Book image (optional)
            if (book.CoverImage != null && book.CoverImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(book.CoverImage))
                {
                    pctBook.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pctBook.Image = null; // or default image
            }
        }

        private void pnlBookDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
