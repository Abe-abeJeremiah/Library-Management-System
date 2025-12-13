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
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           
            // 1. Create a new OpenFileDialog object
            OpenFileDialog opnfd = new OpenFileDialog();

            // 2. Set the file filter to only allow common image file types
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png|All files (*.*)|*.*";
            opnfd.Title = "Select an Image File";

            // 3. Show the dialog and check if the user clicked OK
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 4. Create a new Bitmap object from the selected file path
                    // The Bitmap class is part of the System.Drawing namespace.
                    Image selectedImage = Image.FromFile(opnfd.FileName);

                    // 5. Assign the image to the PictureBox control to display it
                    pictureBox1.Image = selectedImage;

                    // Optional: Store the file path if needed for saving/uploading later
                    // txtFilePath.Text = opnfd.FileName; 
                }
                catch (Exception ex)
                {
                    // Handle any errors (e.g., file is corrupt or in use)
                    MessageBox.Show("Error loading image: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

