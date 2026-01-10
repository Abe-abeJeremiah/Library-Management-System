using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.InterfaceAdmin
{
    public partial class frmFineHistory : Form
    {
        public frmFineHistory()
        {
            InitializeComponent();
        }

        private void frmFineHistory_Load(object sender, EventArgs e)
        {
            LoadFineHistory();
        }

        private void LoadFineHistory()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                string sql = @"
                SELECT 
                    fw.WaiverID,
                    u.UserName AS Student,
                    a.UserName AS Admin,
                    fw.WaivedAmount,
                    fw.Reason,
                    fw.WaiverDate
                FROM FineWaivers fw
                JOIN Users a ON fw.AdminID = a.UserID
                JOIN Fines f ON fw.FineID = f.FineID
                JOIN Users u ON f.UserID = u.UserID
                ORDER BY fw.WaiverDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFineHistory.DataSource = dt;
                dgvFineHistory.Columns["WaiverID"].Visible = false;
                dgvFineHistory.Columns["WaivedAmount"].DefaultCellStyle.Format = "₱#,##0.00";
            }
        }
    }
}
