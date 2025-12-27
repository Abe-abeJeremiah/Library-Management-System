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
        public void SetData(string title, string author, string isbn)
        {
            lblTitle.Text = title;
            lblSubTitle.Text = subtitle;
            lblAuthor.Text = author;
            lblPages.Text = pages.ToString(); // Assuming 'pages' is an integer
            lblISBN.Text = isbn;
            lblLocation.Text = location;
            lblEditor.Text = editor;
            lblAccessionNumber.Text = accessionNumber;
            lblPhysicalDescripton.Text = physicalDescription;
            lblPublisher.Text = publisher;
            lblPublicationYear.Text = publicationYear.ToString(); // Assuming it's an integer or DateTime
            lblEdition.Text = edition;
            lblLanguage.Text = language;

            // Set the image for the book
            // Assuming you have the image data from SQL as a byte array (e.g., 'imageData')
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pctBook.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pctBook.Image = null; // Set a default image or handle if no image is available
            }





        }
    }
}
