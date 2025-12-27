using System.Configuration;
using System.Data.SqlClient;


namespace LibraryManagementSystem.Database
{
    internal class Connection
    {
        private static readonly string cs = ConfigurationManager.ConnectionStrings["LMSdb"].ConnectionString;

        // Return a NEW SqlConnection each time
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }
    }
}
