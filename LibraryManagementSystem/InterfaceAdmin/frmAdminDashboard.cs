using LibraryManagementSystem.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class frmAdminDashboard : Form
    {
   

        public frmAdminDashboard()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTable();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            LoadAdminInfo();
            LoadChartData();
            
        }

        // ================= ADMIN INFO =================
        private void LoadAdminInfo()
        {
            lblUserName.Text = "ADMIN";
            lblRole.Text = "System Administrator";
        }

        // ================= COUNTS =================
        private void LoadDashboardCounts()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                // Book Available
                SqlCommand cmdAvailable = new SqlCommand(
                    "SELECT COUNT(*) FROM Books WHERE Status = 'Available'", con);
                lblQntyBorrowed.Text = cmdAvailable.ExecuteScalar().ToString();

                // Book Borrowed
                SqlCommand cmdBorrowed = new SqlCommand(
                    "SELECT COUNT(*) FROM BookBorrow WHERE Status = 'Borrowed'", con);
                lblQntyOverdue.Text = cmdBorrowed.ExecuteScalar().ToString();

                // Book Returned
                SqlCommand cmdReturned = new SqlCommand(
                    "SELECT COUNT(*) FROM BookBorrow WHERE Status = 'Returned'", con);
                label7.Text = cmdReturned.ExecuteScalar().ToString();
            }
        }


        // ================= CHART =================
        private void InitializeChart()
        {
            chartDashboard = new Chart();
            chartDashboard.Location = new Point(16, 208);
            chartDashboard.Size = new Size(909, 170);
            chartDashboard.BackColor = Color.FromArgb(37, 42, 64);

            ChartArea area = new ChartArea();
            area.BackColor = Color.FromArgb(37, 42, 64);
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gray;

            chartDashboard.ChartAreas.Add(area);

            Series series = new Series("Books");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(0, 126, 249);
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;

            chartDashboard.Series.Add(series);
            Controls.Add(chartDashboard);
        }

        private void LoadChartData()
        {
            chartDashboard.Series.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Books");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT Status, COUNT(*) AS Total
            FROM BookBorrow
            GROUP BY Status", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    series.Points.AddXY(dr["Status"].ToString(), dr["Total"]);
                }
            }

            chartDashboard.Series.Add(series);
        }


        // ================= TABLE =================
        private void InitializeTable()
        {
            dgvRecentBorrow = new DataGridView();
            dgvRecentBorrow.Location = new Point(16, 385);
            dgvRecentBorrow.Size = new Size(909, 177);

            dgvRecentBorrow.BackgroundColor = Color.FromArgb(37, 42, 64);
            dgvRecentBorrow.ForeColor = Color.White;
            dgvRecentBorrow.EnableHeadersVisualStyles = false;
            dgvRecentBorrow.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 126, 249);
            dgvRecentBorrow.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecentBorrow.RowHeadersVisible = false;
            dgvRecentBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentBorrow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentBorrow.ReadOnly = true;

            Controls.Add(dgvRecentBorrow);
        }

        private void LoadRecentBorrow()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT TOP 10 
                bb.BorrowID,
                u.FullName,
                b.Title,
                bb.BorrowDate,
                bb.DueDate,
                bb.Status
            FROM BookBorrow bb
            JOIN Users u ON bb.UserID = u.UserID
            JOIN Books b ON bb.BookID = b.BookID
            ORDER BY bb.BorrowDate DESC", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRecentBorrow.DataSource = dt;
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void lblQntyBorrowed_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
