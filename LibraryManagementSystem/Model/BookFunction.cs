using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class BookBorrowSystem
    {
        private static List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

        public class BorrowRecord
        {
            public int UserID { get; set; }
            public int BookID { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime DueDate { get; set; }
        }

  
        public static string BorrowBook(Users user, LibraryFunction.Books book)
        {
           
            if (book.AvailableCopies <= 0)
            {
                return "Borrow failed: No available copies.";
            }

            
            int currentBorrowed = borrowRecords.Count(r => r.UserID == user.UserID);
            int maxAllowed = LibraryFunction.BookBorrowLimit.MaxBooks(user.MemberType);

            if (currentBorrowed >= maxAllowed)
            {
                return $"Borrow failed: {user.MemberType} can only borrow {maxAllowed} books.";
            }

            
            int borrowDays = LibraryFunction.MemberBookPrivilege.BorrowDays(user.MemberType);
            DateTime borrowDate = DateTime.Now;
            DateTime dueDate = borrowDate.AddDays(borrowDays);

            borrowRecords.Add(new BorrowRecord
            {
                UserID = user.UserID,
                BookID = book.BookID,
                BorrowDate = borrowDate,
                DueDate = dueDate
            });

    
            book.AvailableCopies--;

            return $"Borrow successful! Return by: {dueDate.ToShortDateString()}";
        }


        public static List<BorrowRecord> GetBorrowedBooks(int userId)
        {
            return borrowRecords.Where(r => r.UserID == userId).ToList();
        }
    }

}
