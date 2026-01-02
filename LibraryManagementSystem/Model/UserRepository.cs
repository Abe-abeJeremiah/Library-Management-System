using System.Data;
using System.Data.SqlClient;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.Model
{
    public class UserRepository
    {
        public DataTable GetByEmail(string email)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE EmailAddress = @Email";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
