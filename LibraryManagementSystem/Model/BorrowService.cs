using System;
using System.Data.SqlClient;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.Model
{
    public class BorrowService
    {
        public static string BorrowBook(int userId, int bookId, string memberType)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                con.Open();

                int borrowDays = LibraryRules.BorrowDays(memberType);
                if (borrowDays == 0)
                    return "Borrow not allowed.";

                DateTime borrowDate = DateTime.Now;
                DateTime dueDate = borrowDate.AddDays(borrowDays);

                string sql = @"
INSERT INTO BookBorrow (UserID, BookID, BorrowDate, DueDate)
VALUES (@UserID, @BookID, @BorrowDate, @DueDate);

UPDATE Books SET AvailableCopies = AvailableCopies - 1
WHERE BookID = @BookID AND AvailableCopies > 0;
";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                cmd.Parameters.AddWithValue("@DueDate", dueDate);

                cmd.ExecuteNonQuery();
                return $"Borrowed successfully. Due: {dueDate:d}";
            }
        }
    }
}
