using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class LibraryRules : Book
    {

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

        public static int BorrowDays(string memberType)
        {
            switch (memberType.ToLower())
            {
                case "faculty":
                    return 40;
                case "staff":
                    return 30;
                case "student":
                    return 20;
                case "guest":
                    return 10;
                default:
                    return 0;
            }
        }


        public static int MaxBooks(string memberType)
        {
            switch (memberType.ToLower())
            {
                case "faculty":
                    return 10;
                case "staff":
                    return 7;
                case "student":
                    return 5;
                case "guest":
                    return 1;
                default:
                    return 0;
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
                    case "faculty":
                        feePerDay = 20; //peso
                        break;
                    case "staff":
                        feePerDay = 20;
                        break;
                    case "student":
                        feePerDay = 30;
                        break;
                    case "guest":
                        feePerDay = 40;
                        break;
                    default:
                        feePerDay = 30;
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
