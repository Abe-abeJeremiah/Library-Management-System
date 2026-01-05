using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Database;
using System.Drawing.Printing;

namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmFines : Form
    {
        private decimal dailyRate = 0;
        private decimal maxFine = 0;
        private int currentFineId = 0; // used for payment

        public frmFines()
        {
            InitializeComponent();
            cmbxPaymentMethod.SelectedIndexChanged += cmbxPaymentMethod_SelectedIndexChanged;
        }

        // MUST MATCH DESIGNER
        private void frmFines_Load_1(object sender, EventArgs e)
        {
            LoadStudentFine();
        }

        // ================= LOAD & COMPUTE FINES =================
        private void LoadStudentFine()
        {
            int userId = LoggedInUser.UserID;
            string memberType = LoggedInUser.Role;

            SetFineRules(memberType);

            decimal totalFine = 0;
            int lastBookId = 0;

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT BorrowID, BookID, DueDate
                    FROM BookBorrow
                    WHERE UserID = @UserID
                    AND Status = 'Borrowed'
                    AND DueDate < GETDATE();
                ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int borrowId = Convert.ToInt32(dr["BorrowID"]);
                            int bookId = Convert.ToInt32(dr["BookID"]);
                            DateTime dueDate = Convert.ToDateTime(dr["DueDate"]);

                            int lateDays = (DateTime.Today - dueDate).Days;
                            if (lateDays <= 0) continue;

                            decimal fine = lateDays * dailyRate;
                            if (fine > maxFine) fine = maxFine;

                            totalFine += fine;
                            lastBookId = bookId;

                            // SAVE FINE IF NOT EXISTS
                            InsertFineIfNotExists(con, userId, borrowId, lateDays, fine);
                        }
                    }
                }

                if (totalFine > 0)
                {
                    txtBookID.Text = lastBookId.ToString();
                    txtFine.Text = totalFine.ToString("0.00");
                    currentFineId = GetLatestFineId(con, userId);
                }
                else
                {
                    txtBookID.Clear();
                    txtFine.Text = "0.00";
                }
            }
        }

        // ================= INSERT FINE =================
        private void InsertFineIfNotExists(SqlConnection con, int userId, int borrowId, int daysLate, decimal amount)
        {
            string check = "SELECT COUNT(*) FROM Fines WHERE BorrowID=@BorrowID AND IsCleared=0";
            using (SqlCommand cmd = new SqlCommand(check, con))
            {
                cmd.Parameters.AddWithValue("@BorrowID", borrowId);
                if ((int)cmd.ExecuteScalar() > 0) return;
            }

            string insert = @"
                INSERT INTO Fines (UserID, BorrowID, DaysLate, DailyRate, FineAmount)
                VALUES (@UserID, @BorrowID, @DaysLate, @Rate, @Amount)";
            using (SqlCommand cmd = new SqlCommand(insert, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@BorrowID", borrowId);
                cmd.Parameters.AddWithValue("@DaysLate", daysLate);
                cmd.Parameters.AddWithValue("@Rate", dailyRate);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.ExecuteNonQuery();
            }
        }

        // ================= GET FINE ID =================
        private int GetLatestFineId(SqlConnection con, int userId)
        {
            string sql = "SELECT TOP 1 FineID FROM Fines WHERE UserID=@UserID AND IsCleared=0 ORDER BY FineID DESC";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                object result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

        // ================= MEMBER TYPE RULES =================
        private void SetFineRules(string memberType)
        {
            switch (memberType)
            {
                case "Student":
                    dailyRate = 5m; maxFine = 500m; break;
                case "Staff":
                case "Faculty":
                    dailyRate = 10m; maxFine = 1000m; break;
                case "Guest":
                    dailyRate = 20m; maxFine = 1500m; break;
                default:
                    dailyRate = 5m; maxFine = 500m; break;
            }
        }

        // ================= PAYMENT METHOD =================
     
        private void cmbxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPaymentMethod.Text == "Gcash")
            {
                txtPaymentDetails.Text = "GCash #: 09XXXXXXXXX";
            }
            else if (cmbxPaymentMethod.Text == "Paypal")
            {
                txtPaymentDetails.Text = "PayPal: library@email.com";
            }
            else if (cmbxPaymentMethod.Text == "Cash")
            {
                txtPaymentDetails.Text = "Pay at librarian counter";
            }
            else
            {
                txtPaymentDetails.Text = "";
            }
        }


        // ================= PAY & SAVE =================
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtFine.Text == "0.00" || currentFineId == 0)
            {
                MessageBox.Show("No fine to pay.");
                return;
            }

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
                    INSERT INTO Payments (FineID, UserID, AmountPaid, PaymentMethod)
                    VALUES (@FineID, @UserID, @Amount, @Method);

                    UPDATE Fines SET IsCleared = 1 WHERE FineID = @FineID;
                ";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FineID", currentFineId);
                    cmd.Parameters.AddWithValue("@UserID", LoggedInUser.UserID);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtFine.Text));
                    cmd.Parameters.AddWithValue("@Method", cmbxPaymentMethod.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Payment recorded successfully!\nOfficial receipt generated.",
                "Payment Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtBookID.Clear();
            txtFine.Text = "0.00";
            txtPaymentDetails.Clear();
            cmbxPaymentMethod.SelectedIndex = -1;
            currentFineId = 0;
        }

        private void lblBorrowerId_Click(object sender, EventArgs e) { }
        private void txtPaymentDetails_TextChanged(object sender, EventArgs e) { }
    }
}
