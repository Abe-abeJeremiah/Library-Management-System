using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Database;


namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class frmAdminFines : Form

    {
        private int selectedFineId = 0;

        public frmAdminFines()
        {
            InitializeComponent();
        }

        private void frmAdminFines_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.Role == "Student")
            {
                MessageBox.Show("Access denied.");
                this.Close();
            }

            LoadActiveFines();
        }
        private void LoadActiveFines()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
            SELECT 
                f.FineID,
                u.FullName,
                b.BookID,
                f.FineAmount,
                f.CreatedAt
            FROM Fines f
            INNER JOIN Users u ON f.UserID = u.UserID
            INNER JOIN BookBorrow b ON f.BorrowID = b.BorrowID
            WHERE f.IsCleared = 0
            ORDER BY f.CreatedAt DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // TEMPORARY: show first fine in labels (since UI not yet DataGridView)
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    selectedFineId = Convert.ToInt32(row["FineID"]);
                    label8.Text = row["FullName"].ToString();
                    label16.Text = row["BookID"].ToString();
                    label9.Text = "₱ " + row["FineAmount"].ToString();
                    label5.Text = Convert.ToDateTime(row["CreatedAt"]).ToShortDateString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedFineId == 0)
            {
                MessageBox.Show("Please select a fine first.");
                return;
            }

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
            INSERT INTO Payments (FineID, AmountPaid, PaymentMethod)
            SELECT FineID, FineAmount, 'Cash'
            FROM Fines
            WHERE FineID = @FineID;

            UPDATE Fines SET IsCleared = 1 WHERE FineID = @FineID;
        ";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FineID", selectedFineId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Fine successfully charged and cleared.");
            LoadActiveFines();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedFineId == 0)
            {
                MessageBox.Show("Please select a fine first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to waive this fine?",
                "Confirm Waiver",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
            UPDATE Fines 
            SET IsCleared = 1, Waived = 1
            WHERE FineID = @FineID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FineID", selectedFineId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Fine waived successfully.");
            LoadActiveFines();
        }
    }
    }
