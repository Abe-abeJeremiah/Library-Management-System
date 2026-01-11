/* Pseudocode / Plan (detailed):
 - Create a reusable class `LoggedInUser` that holds the user's information retrieved from the database.
 - Provide instance properties for fields returned by the SQL query: UserID, UserName, Role (MemberType), ProfileImagePath, ExpirationDate.
 - Expose a static `Current` instance that other classes can read to get the currently logged in user.
 - Provide a `LoadFromRecord(IDataRecord)` method to populate an instance from a SqlDataReader/ IDataRecord (reusable from anywhere that has a reader).
 - Provide a static helper `LoadByCredentials(string connectionString, string email, string passwordHash)` that:
     - opens a SqlConnection using the supplied connection string,
     - executes the same query used in the login form with parameters `@email` and `@password`,
     - if a row is found, populates a `LoggedInUser` instance via `LoadFromRecord`, assigns it to `Current`, and returns it,
     - returns null if no user is found.
 - Provide `Clear()` to reset `Current`.
 - Keep exceptions bubbling up so the caller (e.g. the login form) can show friendly messages or handle logging.
 - Use System.Data types and .NET Framework 4.8 compatible APIs.
*/

using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public class LoggedInUser
    {
        // Static current instance that other parts of the app can read
        public static LoggedInUser Current { get; private set; } = null;

        // User properties (match SQL SELECT columns)
        public int UserID { get; private set; }
        public string UserName { get; private set; }
        public string Role { get; private set; } // MemberType in DB
        public string ProfileImagePath { get; private set; }
        public DateTime? ExpirationDate { get; private set; }

        // Parameterless constructor for manual population if needed
        public LoggedInUser() { }

        // Populate from any IDataRecord (SqlDataReader implements IDataRecord)
        public void LoadFromRecord(IDataRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));

            UserID = record["UserID"] != DBNull.Value ? Convert.ToInt32(record["UserID"]) : 0;
            UserName = record["UserName"] != DBNull.Value ? record["UserName"].ToString() : null;
            Role = record["MemberType"] != DBNull.Value ? record["MemberType"].ToString() : null;
            ProfileImagePath = record["ProfileImagePath"] != DBNull.Value ? record["ProfileImagePath"].ToString() : null;
            ExpirationDate = record["ExpirationDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(record["ExpirationDate"]) : null;
        }

        // Load user by credentials. Returns a populated LoggedInUser or null if not found.
        // Exceptions from ADO.NET are propagated to the caller.
        public static LoggedInUser LoadByCredentials(string connectionString, string email, string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(connectionString)) throw new ArgumentException("Connection string is required.", nameof(connectionString));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email is required.", nameof(email));
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException("Password hash is required.", nameof(passwordHash));

            const string query = @"
                SELECT UserID, UserName, MemberType, ProfileImagePath, ExpirationDate
                FROM dbo.Users
                WHERE EmailAddress = @email
                  AND PasswordHash = @password
                  AND ExpirationDate >= GETDATE()
            ";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordHash;

                con.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        var user = new LoggedInUser();
                        user.LoadFromRecord(dr);
                        Current = user;
                        return user;
                    }
                }
            }

            // No matching user
            return null;
        }

        // Clears the current user session
        public static void Clear()
        {
            Current = null;
        }
    }
}