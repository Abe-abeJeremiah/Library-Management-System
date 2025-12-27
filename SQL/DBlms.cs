using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class DBlms
    {
        public DBlms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestConnection();   // 🔴 IMPORTANT: This calls the database
        }

        private void TestConnection()
        {
            string connStr = @"Server=localhost\SQLEXPRESS;
                               Database=master;
                               Integrated Security=True;
                               TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("✅ Connected to SQL Server successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Connection failed:\n" + ex.Message);
                }
            }
        }

        private void CreateTables()
        {
            string connSTR = @"Server=localhost\SQLEXPRESS;
                                 Database=LibraryDB;
                                 Integrated Security=True;
                                 TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connSTR))
            {
                conn.Open();

                string sql = @"IF Object_ID('Student') is NULL
                               CREATE TABLE Student (
                                   StudentID INT PRIMARY KEY,
                                   FName NVARCHAR(100),
                                   LName NVARCHAR(100),
                                   Mname NVARCHAR(100),
                                   Email NVARCHAR(100),
                                   ContactNo NVARCHAR(15),
                                   Address NVARCHAR(200)
                               );
                               IF Object_ID('Employee') is NULL
                               CREATE TABLE Employee (
                                   EmployeeID INT PRIMARY KEY,
                                   Fname NVARCHAR(200),
                                   Lname NVARCHAR(100),
                                   Mname NVARCHAR(100),
                                   Email NVARCHAR(100),
                                   ContactNo NVARCHAR(15)
                               );
                               IF Object_ID('Books') is NULL
                               CREATE TABLE Books (
                                    BookID INT PRIMARY KEY,
                                    Title NVARCHAR(200),
                                    Author NVARCHAR(100),
                                    Publisher NVARCHAR(100),
                                    YearPublished INT,
                                    ISBN NVARCHAR(20),
                                    CopiesAvailable INT
                                 );
";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("✅ Tables created successfully (if they did not exist)."); q
            }
        }
    }
}
