using LibraryManagementSystem.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LibraryManagementSystem.UserInterface_Forms
{
    public partial class frmHistory : Form
    {
        private int currentUserId = 1;

        public frmHistory()
        {
            InitializeComponent();
            LoadBorrowHistory();
            LoadPenaltyHistory();
            LoadAccountHistory();
        }

        // ======================================================
        // 1️⃣ BORROW & RETURN HISTORY
        // ======================================================
        private void LoadBorrowHistory()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        bb.BookID,
                        bb.BorrowDate,
                        br.ReturnDate,
                        b.Title,
                        b.Author,
                        b.Publisher,
                        b.Edition,
                        b.Category,
                        b.Language,
                        b.PublicationYear
                    FROM BookBorrow bb
                    INNER JOIN Books b ON bb.BookID = b.BookID
                    LEFT JOIN BookReturn br ON bb.BorrowID = br.BorrowID
                    WHERE bb.UserID = @uid
                    ORDER BY bb.BorrowDate DESC", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);

                SqlDataReader rdr = cmd.ExecuteReader();
                grdDashboard.Rows.Clear();

                while (rdr.Read())
                {
                    grdDashboard.Rows.Add(
                        rdr["BookID"],
                        Convert.ToDateTime(rdr["BorrowDate"]).ToShortDateString(),
                        rdr["ReturnDate"] == DBNull.Value ? "Not Returned"
                            : Convert.ToDateTime(rdr["ReturnDate"]).ToShortDateString(),
                        "—", // Librarian not stored
                        rdr["Title"],
                        rdr["Author"],
                        rdr["Publisher"],
                        rdr["Edition"],
                        rdr["Category"],
                        rdr["Language"],
                        rdr["PublicationYear"]
                    );
                }
            }
        }

        // ======================================================
        // 2️⃣ OVERDUE & PENALTY HISTORY
        // ======================================================
        private void LoadPenaltyHistory()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        bb.BookID,
                        b.Author,
                        f.DaysLate,
                        f.FineAmount,
                        b.Publisher,
                        b.Edition,
                        b.Category,
                        b.Language,
                        b.PublicationYear
                    FROM Fines f
                    INNER JOIN BookBorrow bb ON f.BorrowID = bb.BorrowID
                    INNER JOIN Books b ON bb.BookID = b.BookID
                    WHERE f.UserID = @uid", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);

                SqlDataReader rdr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(
                        rdr["BookID"],
                        rdr["Author"],
                        rdr["DaysLate"],
                        rdr["FineAmount"],
                        rdr["Publisher"],
                        rdr["Edition"],
                        rdr["Category"],
                        rdr["Language"],
                        rdr["PublicationYear"]
                    );
                }
            }
        }

        // ======================================================
        // 3️⃣ ACCOUNT ACTIVITY HISTORY
        // ======================================================
        private void LoadAccountHistory()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        RegistrationDate,
                        MemberType,
                        ExpirationDate
                    FROM Users
                    WHERE UserID = @uid", con);

                cmd.Parameters.AddWithValue("@uid", currentUserId);

                SqlDataReader rdr = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();

                while (rdr.Read())
                {
                    dataGridView2.Rows.Add(
                        Convert.ToDateTime(rdr["RegistrationDate"]).ToShortDateString(),
                        "—",
                        "—",
                        Convert.ToDateTime(rdr["ExpirationDate"]) >= DateTime.Now
                            ? "Active" : "Expired"
                    );
                }
            }
        }

        private void grdDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
