using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class txtBookTitle : Form
    {
        public txtBookTitle()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
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
                {
                    try
                    {
                        // 4. Create a new Bitmap object from the selected file path
                        // The Bitmap class is part of the System.Drawing namespace.
                        Image selectedImage = Image.FromFile(opnfd.FileName);

                        // 5. Assign the image to the PictureBox control to display it
                        pcBook.Image = selectedImage;

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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}
