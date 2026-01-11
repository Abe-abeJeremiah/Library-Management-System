using LibraryManagementSystem.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
// using System.Windows.Forms.DataVisualization.Charting;


namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmDashboard : Form
    {
        // TEMP: Replace with actual logged-in UserID
        private int currentUserId = 1;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            //  LoadBooks();
            // LoadBorrowReturnChart();
            //   LoadMonthlyBorrowChart();
            //   LoadFinesSummary();
        }

        // ================================
        // DASHBOARD COUNTS
        // ================================
        private void LoadDashboardCounts()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                // Borrowed
                SqlCommand cmdBorrowed = new SqlCommand(
                    "SELECT COUNT(*) FROM BookBorrow WHERE UserID=@uid AND Status='Borrowed'", con);
                cmdBorrowed.Parameters.AddWithValue("@uid", currentUserId);
                lblQntyBorrowed.Text = cmdBorrowed.ExecuteScalar().ToString();

                // Overdue
                SqlCommand cmdOverdue = new SqlCommand(
                    @"SELECT COUNT(*) FROM BookBorrow 
                      WHERE UserID=@uid AND DueDate < GETDATE() AND Status='Borrowed'", con);
                cmdOverdue.Parameters.AddWithValue("@uid", currentUserId);
                lblQntyOverdue.Text = cmdOverdue.ExecuteScalar().ToString();

                // Returned
                SqlCommand cmdReturned = new SqlCommand(
                    @"SELECT COUNT(*) FROM BookReturn r
                      JOIN BookBorrow b ON r.BorrowID = b.BorrowID
                      WHERE b.UserID=@uid", con);
                cmdReturned.Parameters.AddWithValue("@uid", currentUserId);
                label7.Text = cmdReturned.ExecuteScalar().ToString();

            }
        }

        /*
        private void LoadBorrowReturnChart()
        {
            chartDashboard.Series.Clear();
            chartDashboard.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chartDashboard.ChartAreas.Add(area);

            Series series = new Series("Books");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;  
            series.LabelForeColor = Color.Black;


            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand borrowedCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM BookBorrow WHERE UserID=@uid", con);
                borrowedCmd.Parameters.AddWithValue("@uid", currentUserId);
                int borrowed = (int)borrowedCmd.ExecuteScalar();

                SqlCommand returnedCmd = new SqlCommand(
                    @"SELECT COUNT(*) FROM BookReturn r
              JOIN BookBorrow b ON r.BorrowID=b.BorrowID
              WHERE b.UserID=@uid", con);
                returnedCmd.Parameters.AddWithValue("@uid", currentUserId);
                int returned = (int)returnedCmd.ExecuteScalar();

                series.Points.AddXY("Borrowed", borrowed);
                series.Points.AddXY("Returned", returned);
            }

            chartDashboard.Series.Add(series);
        }
        private void LoadMonthlyBorrowChart()
        {
            Series series = new Series("Monthly Borrow");
            series.ChartType = SeriesChartType.Line;
            series.IsValueShownAsLabel = true;


            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT MONTH(BorrowDate) AS Month, COUNT(*) AS Total
              FROM BookBorrow
              WHERE UserID=@uid
              GROUP BY MONTH(BorrowDate)
              ORDER BY Month", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    series.Points.AddXY(
                        "Month " + reader["Month"],
                        reader["Total"]
                    );
                }
            }

            chartDashboard.Series.Add(series);
        }
        private void LoadFinesSummary()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand totalCmd = new SqlCommand(
                    "SELECT ISNULL(SUM(FineAmount),0) FROM Fines WHERE UserID=@uid", con);
                totalCmd.Parameters.AddWithValue("@uid", currentUserId);
                lblTotalFines.Text = "₱ " + totalCmd.ExecuteScalar().ToString();

                SqlCommand paidCmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(AmountPaid),0)
              FROM Payments WHERE UserID=@uid", con);
                paidCmd.Parameters.AddWithValue("@uid", currentUserId);
                lblPaidFines.Text = "₱ " + paidCmd.ExecuteScalar().ToString();

                SqlCommand unpaidCmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(FineAmount),0)
              FROM Fines WHERE UserID=@uid AND IsCleared=0", con);
                unpaidCmd.Parameters.AddWithValue("@uid", currentUserId);
                lblUnpaidFines.Text = "₱ " + unpaidCmd.ExecuteScalar().ToString();
            }
        }


        // ================================
        // BOOKS TABLE
        // ================================
        private void LoadBooks()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                        Title,
                        Author,
                        Publisher,
                        Language,
                        PublicationYear
                      FROM Books", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                grdDashboard.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    grdDashboard.Rows.Add(
                        row["Title"],
                        row["Author"],
                        row["Publisher"],
                        "", // Category placeholder
                        row["Language"],
                        row["PublicationYear"]
                    );
                }
            }
        }

        // ================================
        // UNUSED EVENTS (SAFE)
        // ================================
        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void grdDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblQntyReturned_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
