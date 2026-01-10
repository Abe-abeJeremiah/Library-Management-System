using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class frmAdminFines : Form
    {
        private int selectedFineId;
        private int selectedUserId;
        private decimal selectedFineAmount;
        private decimal remainingAmount;
        private int selectedPaymentId;
        private string selectedPaymentStatus;


        public frmAdminFines()
        {
            InitializeComponent();
        }


        private void frmAdminFines_Load(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            dgvAllPayments.Columns.Clear();
            dgvAllPayments.AutoGenerateColumns = true;


            if (LoggedInUser.Role == "Student")
            {
                MessageBox.Show("Access denied.");
                Close();
                return;
            }

            // 🔁 Switch later to LoadActiveFines()
            LoadActiveFines();
            LoadAllPayments();

        }

        // ================= REAL DATA =================
        private void LoadActiveFines()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
    SELECT 
        f.FineID,
        f.UserID,
        f.IsLost,
        CONVERT(date, f.CreatedAt) AS [Date],
        CONVERT(varchar, f.CreatedAt, 108) AS [Time],
        b.BorrowDate,
        b.DueDate,
        r.ReturnDate,
        u.UserName AS [Name],
        b.BookID,
        f.FineAmount AS [Penalty],
        f.RemainingAmount
        
    FROM Fines f
    JOIN Users u ON f.UserID = u.UserID
    JOIN BookBorrow b ON f.BorrowID = b.BorrowID
    LEFT JOIN BookReturn r ON b.BorrowID = r.BorrowID
    WHERE f.IsCleared = 0
    ORDER BY f.CreatedAt DESC";


                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFines.DataSource = dt;
                ApplyGridStyle();
                
                UpdateReturnDateDisplay();


                if (dgvFines.Columns.Contains("FineID"))
                    dgvFines.Columns["FineID"].Visible = false;

                if (dgvFines.Columns.Contains("UserID"))
                    dgvFines.Columns["UserID"].Visible = false;

                if (dgvFines.Columns.Contains("RemainingAmount"))
                    dgvFines.Columns["RemainingAmount"].Visible = false;


                if (dgvFines.Columns.Contains("IsLost"))
                    dgvFines.Columns["IsLost"].Visible = false;



                dgvFines.Columns["Penalty"].DefaultCellStyle.Format = "₱#,##0.00";
                dgvFines.Columns["ReturnDate"].DefaultCellStyle.NullValue = "Not returned";





                dgvFines.ColumnHeadersVisible = true; 

            }
        }
       
        private void UpdateReturnDateDisplay()
        {
            foreach (DataGridViewRow row in dgvFines.Rows)
            {
                if (row.IsNewRow) continue;

                bool isLost = Convert.ToBoolean(row.Cells["IsLost"].Value);

                if (isLost)
                {
                    row.Cells["ReturnDate"].Value = "LOST";
                }
                else if (row.Cells["ReturnDate"].Value == DBNull.Value)
                {
                    row.Cells["ReturnDate"].Value = "Not returned";
                }
                else
                {
                    // Format actual return date nicely
                    DateTime returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                    row.Cells["ReturnDate"].Value = returnDate.ToString("yyyy-MM-dd");
                }
            }
        }



        // ================= ALL PAYMENTS & CHARGES =================
        private void LoadAllPayments()
        {
            dgvAllPayments.Columns.Clear();
            dgvAllPayments.AutoGenerateColumns = true;

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
        SELECT 
            u.UserName AS [Name],
            p.PaymentID,
            ISNULL(CAST(p.FineID AS VARCHAR), CAST(p.OtherChargeID AS VARCHAR)) AS ReferenceID,
            CASE 
                WHEN p.FineID IS NOT NULL THEN 'Overdue Fine'
                ELSE oc.ChargeType
            END AS ChargeType,
            p.AmountPaid AS Amount,
            p.PaymentMethod,
            p.Status,
            p.PaymentDate
        FROM Payments p
        LEFT JOIN Fines f ON p.FineID = f.FineID
        LEFT JOIN OtherCharges oc ON p.OtherChargeID = oc.OtherChargeID
        JOIN Users u ON p.UserID = u.UserID
        ORDER BY p.PaymentDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAllPayments.DataSource = dt;

                ApplyPaymentsGridStyle();
                


                dgvAllPayments.Columns["Amount"].DefaultCellStyle.Format = "₱#,##0.00";
                dgvAllPayments.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllPayments.Columns["PaymentID"].Visible = false;
            }
        }

        // ✅ Check if a waiver request exists for the selected fine
        private void CheckWaiverRequest(int fineId)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT TOP 1 WaivedAmount, Reason
            FROM FineWaivers
            WHERE FineID = @FineID AND Status = 'Pending'
            ORDER BY CreatedAt DESC", con);

                cmd.Parameters.AddWithValue("@FineID", fineId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal requestedAmount = reader.GetDecimal(0);
                    string reason = reader.GetString(1);

                    reader.Close();

                    // Pop-up for admin to read only
                    MessageBox.Show(
                        $"Waiver Request Found:\nAmount: ₱{requestedAmount:0.00}\nReason: {reason}\n\nYou can now decide the deduction manually.",
                        "Waiver Request",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Admin will manually type deduction in txtDeduction and press button2
                }
                else
                {
                    reader.Close();
                    // No pending waiver
                }
            }
        }





        // ================= SAMPLE DATA =================
        private void LoadSampleFines()
        {
            dgvFines.ColumnHeadersVisible = false;
            dgvFines.RowHeadersVisible = false;
            dgvFines.AllowUserToAddRows = false;
            dgvFines.AllowUserToResizeRows = false;

            DataTable dt = new DataTable();

            dt.Columns.Add("FineID", typeof(int));
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("BorrowDate", typeof(string));
            dt.Columns.Add("ReturnDate", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("BookID", typeof(string));
            dt.Columns.Add("Penalty", typeof(decimal));

            dt.Rows.Add(1, 101, "2026-01-06", "10:30 AM", "2025-12-28", "2026-01-05", "Juan Dela Cruz", "BK-001", 50);
            dt.Rows.Add(2, 102, "2026-01-04", "09:10 AM", "2025-12-20", "2026-01-03", "Maria Santos", "BK-014", 120);
            dt.Rows.Add(3, 103, "2026-01-05", "01:45 PM", "2025-12-30", "2026-01-05", "Pedro Reyes", "BK-022", 75);

            dgvFines.DataSource = dt;

            dgvFines.Columns["FineID"].Visible = false;
            dgvFines.Columns["UserID"].Visible = false;

            dgvFines.Columns["Penalty"].DefaultCellStyle.Format = "₱#,##0.00";

            ApplyGridStyle();
           

            if (dgvFines.Rows.Count > 0)
                dgvFines.Rows[0].Selected = true;
        }

      





        // ================= BUTTONS =================
        private bool GetSelectedFine()
        {
            if (dgvFines.SelectedRows.Count == 0)
            {
               
                button2.Enabled = false;
                return false;
            }

            DataGridViewRow row = dgvFines.SelectedRows[0];

            if (row.Cells["FineID"].Value == DBNull.Value)
            {
               
                button2.Enabled = false;
                return false;
            }

            selectedFineId = Convert.ToInt32(row.Cells["FineID"].Value);

            if (selectedFineId <= 0)
            {
                
                button2.Enabled = false;
                return false;
            }

            selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
            selectedFineAmount = Convert.ToDecimal(row.Cells["Penalty"].Value);
            if (dgvFines.Columns.Contains("RemainingAmount") && row.Cells["RemainingAmount"].Value != DBNull.Value)
            {
                remainingAmount = Convert.ToDecimal(row.Cells["RemainingAmount"].Value);
            }
            else
            {
                remainingAmount = 0; // default value if column missing or null
            }


            bool isLost = false;
            if (dgvFines.Columns.Contains("IsLost") && row.Cells["IsLost"].Value != DBNull.Value)
            {
                isLost = Convert.ToBoolean(row.Cells["IsLost"].Value);
            }


            // ✅ BUTTON RULES

            button2.Enabled = remainingAmount > 0;             // waiver always allowed
            btnMarkPaid.Enabled = remainingAmount == 0;

            return true;
        }


        private void dgvAllPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header clicked
            if (dgvAllPayments.Rows.Count == 0) return; // empty table

            DataGridViewRow row = dgvAllPayments.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            if (row.Cells["PaymentID"].Value == DBNull.Value) return;

            selectedPaymentId = Convert.ToInt32(row.Cells["PaymentID"].Value);
            selectedPaymentStatus = row.Cells["Status"].Value.ToString();

            // ✅ Enable buttons only if pending
            btnApprovePaymentGlobal.Enabled = selectedPaymentStatus == "Pending";
            btnRejectPayment.Enabled = selectedPaymentStatus == "Pending";
        }





        //================================================\\

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (!GetSelectedFine()) return;

            if (remainingAmount <= 0)
            {
                MessageBox.Show("This fine is already settled.");
                return;
            }


            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                // Check if payment exists
                SqlCommand checkPayment = new SqlCommand(@"
            SELECT COUNT(*) FROM Payments
            WHERE FineID = @FineID AND Status = 'Pending'", con);

                checkPayment.Parameters.AddWithValue("@FineID", selectedFineId);

                int hasPayment = (int)checkPayment.ExecuteScalar();

                if (hasPayment == 0)
                {
                    MessageBox.Show("No pending payment found for this fine.");
                    return;
                }

                // Approve payment
                SqlCommand approvePay = new SqlCommand(@"
            UPDATE Payments
            SET Status = 'Approved'
            WHERE FineID = @FineID", con);

                approvePay.Parameters.AddWithValue("@FineID", selectedFineId);
                approvePay.ExecuteNonQuery();

                // Deduct approved payment from remaining fine amount
                SqlCommand deductAmount = new SqlCommand(@"
        UPDATE Fines
        SET RemainingAmount = FineAmount - (
        SELECT ISNULL(SUM(AmountPaid), 0)
        FROM Payments
        WHERE FineID = @FineID AND Status = 'Approved'
        )
        WHERE FineID = @FineID
        ", con);

                deductAmount.Parameters.AddWithValue("@FineID", selectedFineId);
                deductAmount.ExecuteNonQuery();

            }

            MessageBox.Show("Payment approved successfully.");

            LoadActiveFines();

            txtDeduction.Clear();
            LoadAllPayments();

        }*/
        //====================================================================\\






        private void button2_Click(object sender, EventArgs e)
{
    if (!GetSelectedFine()) return;

    decimal deduction = 0;

    if (!decimal.TryParse(txtDeduction.Text, out deduction))
    {
        MessageBox.Show("Invalid deduction amount.");
        return;
    }

    if (deduction > remainingAmount)

    {
        MessageBox.Show("Deduction cannot exceed remaining balance.");


        return;
    }

    decimal waivedAmount = deduction == 0 ? remainingAmount : deduction;


    if (MessageBox.Show(
        $"Waive ₱{waivedAmount:0.00}?",
        "Confirm Waiver",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning) != DialogResult.Yes)
        return;

    using (SqlConnection con = Connection.GetConnection())
    {
        con.Open();

        SqlCommand waive = new SqlCommand(@"
    INSERT INTO FineWaivers (FineID, AdminID, Reason, WaivedAmount)
    VALUES (@FineID, @AdminID, 'Partial/Full waiver', @Amount)", con);

        waive.Parameters.AddWithValue("@FineID", selectedFineId);
        waive.Parameters.AddWithValue("@AdminID", LoggedInUser.UserID);
        waive.Parameters.AddWithValue("@Amount", waivedAmount);
        waive.ExecuteNonQuery();

                // ✅ Mark the waiver as approved
                SqlCommand updateWaiver = new SqlCommand(@"
        UPDATE FineWaivers
        SET Status = 'Approved'
        WHERE FineID = @FineID AND Status = 'Pending'", con);
                updateWaiver.Parameters.AddWithValue("@FineID", selectedFineId);
                updateWaiver.ExecuteNonQuery();

                decimal newRemaining = remainingAmount - waivedAmount;

        SqlCommand updateFine;

        if (newRemaining <= 0)
        {
            // Fully cleared
            updateFine = new SqlCommand(@"
UPDATE Fines
SET IsCleared = 1,
    RemainingAmount = 0
WHERE FineID = @FineID", con);
        }
        else
        {
            // Partially cleared
            updateFine = new SqlCommand(@"
UPDATE Fines
SET RemainingAmount = @Remaining
WHERE FineID = @FineID", con);

            updateFine.Parameters.AddWithValue("@Remaining", newRemaining);
        }

        updateFine.Parameters.AddWithValue("@FineID", selectedFineId);
        updateFine.ExecuteNonQuery();

    }

    MessageBox.Show("Fine waived successfully.");
    LoadActiveFines();

    txtDeduction.Clear();
    LoadAllPayments();


}



private void btnMarkPaid_Click(object sender, EventArgs e)
{
    if (!GetSelectedFine()) return;

    if (remainingAmount > 0)
    {
        MessageBox.Show("This fine still has a remaining balance.");
        return;
    }

    if (MessageBox.Show(
        "Mark this fine as fully PAID?",
        "Confirm",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) != DialogResult.Yes)
        return;

    using (SqlConnection con = Connection.GetConnection())
    {
        con.Open();

        SqlCommand cmd = new SqlCommand(@"
    UPDATE Fines
    SET IsCleared = 1
    WHERE FineID = @FineID", con);

        cmd.Parameters.AddWithValue("@FineID", selectedFineId);
        cmd.ExecuteNonQuery();
    }

    MessageBox.Show("Fine marked as PAID.");
    LoadActiveFines();
    LoadAllPayments();
}





private void btnApprovePaymentGlobal_Click_1(object sender, EventArgs e)
{
    if (selectedPaymentId <= 0 || selectedPaymentStatus != "Pending")
    {
        MessageBox.Show("Select a pending payment.");
        return;
    }

    using (SqlConnection con = Connection.GetConnection())
    {
        con.Open();

        // Approve payment
        SqlCommand approve = new SqlCommand(@"
    UPDATE Payments
    SET Status = 'Approved'
    WHERE PaymentID = @PaymentID", con);
        approve.Parameters.AddWithValue("@PaymentID", selectedPaymentId);
        approve.ExecuteNonQuery();

        // Recalculate fine balance
        SqlCommand updateFine = new SqlCommand(@"
    UPDATE Fines
    SET RemainingAmount = FineAmount - (
        SELECT ISNULL(SUM(AmountPaid),0)
        FROM Payments
        WHERE FineID = Fines.FineID
        AND Status = 'Approved'
    ),
    IsCleared = CASE
        WHEN FineAmount - (
            SELECT ISNULL(SUM(AmountPaid),0)
            FROM Payments
            WHERE FineID = Fines.FineID
            AND Status = 'Approved'
        ) <= 0 THEN 1
        ELSE 0
    END
    WHERE FineID = (
        SELECT FineID FROM Payments WHERE PaymentID = @PaymentID
    )", con);

        updateFine.Parameters.AddWithValue("@PaymentID", selectedPaymentId);
        updateFine.ExecuteNonQuery();
    }

    MessageBox.Show("Payment approved successfully.");

    LoadAllPayments();
    LoadActiveFines();

    btnApprovePaymentGlobal.Enabled = false;
    btnRejectPayment.Enabled = false;
}





private void btnRejectPayment_Click_1(object sender, EventArgs e)
{
    if (selectedPaymentId <= 0)
    {
        MessageBox.Show("Please select a payment.");
        return;
    }

    if (selectedPaymentStatus != "Pending")
    {
        MessageBox.Show("Only pending payments can be rejected.");
        return;
    }

    if (MessageBox.Show(
        "Reject this payment?",
        "Confirm",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning) != DialogResult.Yes)
        return;

    using (SqlConnection con = Connection.GetConnection())
    {
        con.Open();

        SqlCommand cmd = new SqlCommand(@"
    UPDATE Payments
    SET Status = 'Rejected'
    WHERE PaymentID = @PaymentID", con);

        cmd.Parameters.AddWithValue("@PaymentID", selectedPaymentId);
        cmd.ExecuteNonQuery();
    }

    MessageBox.Show("Payment rejected.");

    LoadAllPayments();

    btnApprovePaymentGlobal.Enabled = false;
    btnRejectPayment.Enabled = false;
}




private void btnFineHistory_Click(object sender, EventArgs e)
{
    frmFineHistory history = new frmFineHistory();
    history.ShowDialog();
}



        private void dgvFines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header clicked
            if (dgvFines.Rows.Count == 0) return; // empty table

            DataGridViewRow row = dgvFines.Rows[e.RowIndex];
            if (row.IsNewRow) return; // ignore new row

            dgvFines.Rows[e.RowIndex].Selected = true;

            if (!GetSelectedFine()) return;

            // Check for pending waiver request safely
            CheckWaiverRequest(selectedFineId);
        }


        private void dgvFines_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void label1_Click(object sender, EventArgs e)
{

}

private void dgvAllPayments_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
{

}



// ================= GRID STYLE =================
private void ApplyGridStyle()
{
    dgvFines.RowTemplate.Height = 40;
    dgvFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    dgvFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dgvFines.MultiSelect = false;
    dgvFines.ReadOnly = true;

    dgvFines.EnableHeadersVisualStyles = false;
    dgvFines.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 60);
    dgvFines.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    dgvFines.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
    dgvFines.DefaultCellStyle.ForeColor = Color.White;
    dgvFines.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 100, 160);
    dgvFines.DefaultCellStyle.SelectionForeColor = Color.White;

    dgvFines.RowHeadersVisible = false;
}

private void ApplyPaymentsGridStyle()
{
    dgvAllPayments.RowTemplate.Height = 38;
    dgvAllPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    dgvAllPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dgvAllPayments.MultiSelect = false;
    dgvAllPayments.ReadOnly = true;

    dgvAllPayments.EnableHeadersVisualStyles = false;

    dgvAllPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 60);
    dgvAllPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    dgvAllPayments.ColumnHeadersDefaultCellStyle.Font =
        new Font("Segoe UI", 8, FontStyle.Bold);

    dgvAllPayments.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
    dgvAllPayments.DefaultCellStyle.ForeColor = Color.White;
    dgvAllPayments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 100, 160);
    dgvAllPayments.DefaultCellStyle.SelectionForeColor = Color.White;

    dgvAllPayments.RowHeadersVisible = false;
    dgvAllPayments.ColumnHeadersHeight = 40;


    dgvAllPayments.ColumnHeadersVisible = true;
    dgvAllPayments.Refresh();

}



}
}
