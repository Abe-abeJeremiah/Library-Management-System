using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class txtBookTitle : Form
    {
        // 🔹 ADDED: store image path
        private string imagePath = "";

        public txtBookTitle()
        {
            InitializeComponent();
        }

        // ================= IMAGE UPLOAD =================
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            opnfd.Title = "Select Book Image";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcBook.Image = Image.FromFile(opnfd.FileName);
                    imagePath = opnfd.FileName; // 🔹 SAVE PATH
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        // ================= ADD BOOK =================
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // 🔹 BASIC VALIDATION
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Book Title and Author are required.");
                return;
            }

            try
            {
                string connStr = ConfigurationManager
                    .ConnectionStrings["LibraryDB"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = @"
                    INSERT INTO Books
                    (Title, SubTitle, Author, Pages, ISBN, Location, Editor,
                     AccessionNumber, PhysicalDescription, Publisher,
                     PublicationYear, Edition, Language, AvailableCopies, BookImagePath)
                    VALUES
                    (@Title, @SubTitle, @Author, @Pages, @ISBN, @Location, @Editor,
                     @AccessionNumber, @PhysicalDescription, @Publisher,
                     @PublicationYear, @Edition, @Language, @AvailableCopies, @BookImagePath)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Title", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SubTitle", txtSubTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Pages", int.TryParse(txtPages.Text, out int p) ? p : 0);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@Editor", txtEditor.Text);
                    cmd.Parameters.AddWithValue("@AccessionNumber", txtAccessionNumber.Text);
                    cmd.Parameters.AddWithValue("@PhysicalDescription", txtPhysicalDescription.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                    cmd.Parameters.AddWithValue("@PublicationYear", dtmPublicationYear.Value.Year);
                    cmd.Parameters.AddWithValue("@Edition", txtEdition.Text);
                    cmd.Parameters.AddWithValue("@Language", txtLanguage.Text);
                    cmd.Parameters.AddWithValue("@AvailableCopies",
                        int.TryParse(txtCopies.Text, out int c) ? c : 1);
                    cmd.Parameters.AddWithValue("@BookImagePath", imagePath);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Book added successfully!");
                ClearFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= CLEAR FORM =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            txtSubTitle.Clear();
            txtAuthor.Clear();
            txtPages.Clear();
            txtISBN.Clear();
            txtLocation.Clear();
            txtEditor.Clear();
            txtAccessionNumber.Clear();
            txtPhysicalDescription.Clear();
            txtPublisher.Clear();
            txtEdition.Clear();
            txtLanguage.Clear();
            txtCopies.Clear();
            pcBook.Image = null;
            imagePath = "";
        }

        // ================= UNUSED EVENTS (SAFE TO KEEP) =================
        private void label12_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void txtBookTitle_Load(object sender, EventArgs e) { }
    }
}
