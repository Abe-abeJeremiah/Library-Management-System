using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class LibraryFunction
    {
        public class Books
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int PublishedYear { get; set; }
            public string Genre { get; set; }
            public int AvailableCopies { get; set; }
        }

        public class BookStatus
        {
            public static string Status(int AvailableCopies)
            {
                if (AvailableCopies > 0)
                {
                    return "Available";
                }
                else
                {
                    return "Checked Out";
                }
            }
        }

        public class MemberBookPrivilege
        {
            public static int BorrowDays(string MemberType)
            {
                switch (MemberType.ToLower())
                {
                    case "Faculty":
                        return 40; //days
                    case "Staff":
                        return 30;
                    case "Student":
                        return 15;
                    case "Guest":
                        return 0;
                    default:
                        return 0;
                }
            }
        }

        public class BookBorrowLimit
        {
            public static int MaxBooks(string MemberType)
            {
                switch (MemberType.ToLower())
                {
                    case "Faculty":
                        return 10; //books
                    case "Staff":
                        return 7;
                    case "Student":
                        return 5;
                    case "Guest":
                        return 2;
                    default:
                        return 0;
                }
            }
        }

        public class BorrowReturn
        {
            public DateTime BorrowDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public DateTime CalculateReturnDate(DateTime borrowDate, int borrowDays)
            {
                return borrowDate.AddDays(borrowDays);
            }
        }

        public class LateFee
        {
            public static decimal CalculateLateFee(int lateDays, string MemberType)
            {
                decimal feePerDay;
                switch (MemberType.ToLower())
                {
                    case "Faculty":
                        feePerDay = 10;
                        break;
                    case "Staff":
                        feePerDay = 10;
                        break;
                    case "Student":
                        feePerDay = 10;
                        break;
                    case "Guest":
                        feePerDay = 10;
                        break;
                    default:
                        feePerDay = 0;
                        break;
                }
                return lateDays * feePerDay;
            }
        }

        public class BookReservation
        {
            public static string ReservationStatus(int AvailableCopies)
            {
                if (AvailableCopies > 0)
                {
                    return "Can Reserve";
                }
                else
                {
                    return "Cannot Reserve";
                }
            }
        }

        public class BookAlreadyReserved
        {
            private static List<int> reservedBookIDs = new List<int>();
            public static bool IsBookReserved(int bookID)
            {
                return reservedBookIDs.Contains(bookID);
            }
            public static void ReserveBook(int bookID)
            {
                if (!IsBookReserved(bookID))
                {
                    reservedBookIDs.Add(bookID);
                }
            }
        }


    }
}
