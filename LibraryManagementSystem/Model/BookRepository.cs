using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem.Model
{
    public class BookRepository 
    {
        public LibraryBook GetBookByISBN(string isbn)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                string sql = "SELECT * FROM Books WHERE ISBN = @ISBN";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ISBN", isbn);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read()) return null;

                return new LibraryBook
                {
                    BookID = (int)dr["BookID"],
                    Title = dr["Title"].ToString(),
                    SubTitle = dr["SubTitle"].ToString(),
                    Author = dr["Author"].ToString(),
                    Pages = dr["Pages"] == DBNull.Value ? 0 : (int)dr["Pages"],
                    ISBN = dr["ISBN"].ToString(),
                    Location = dr["Location"].ToString(),
                    Editor = dr["Editor"].ToString(),
                    AccessionNumber = dr["AccessionNumber"].ToString(),
                    PhysicalDescription = dr["PhysicalDescription"].ToString(),
                    Publisher = dr["Publisher"].ToString(),
                    PublicationYear = (int)dr["PublicationYear"],
                    Edition = dr["Edition"].ToString(),
                    Language = dr["Language"].ToString(),
                    AvailableCopies = (int)dr["AvailableCopies"],
                    BookImagePath = dr["BookImagePath"]?.ToString()

                };
            }
        }
        public List<LibraryBook> GetAllBooks()
        {
            List<LibraryBook> books = new List<LibraryBook>();

            using (SqlConnection con = Connection.GetConnection())
            {
                string sql = "SELECT * FROM Books";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    books.Add(new LibraryBook
                    {
                        BookID = (int)dr["BookID"],
                        Title = dr["Title"].ToString(),
                        SubTitle = dr["SubTitle"].ToString(),
                        Author = dr["Author"].ToString(),
                        Pages = dr["Pages"] == DBNull.Value ? 0 : (int)dr["Pages"],
                        ISBN = dr["ISBN"].ToString(),
                        Publisher = dr["Publisher"].ToString(),
                        Edition = dr["Edition"].ToString(),
                        Location = dr["Location"].ToString(),
                        Editor = dr["Editor"].ToString(),
                        Language = dr["Language"].ToString(),
                        PhysicalDescription = dr["PhysicalDescription"].ToString(),
                        AccessionNumber = dr["AccessionNumber"].ToString(),
                        PublicationYear = dr["PublicationYear"] == DBNull.Value ? 0 : (int)dr["PublicationYear"],
                        AvailableCopies = dr["AvailableCopies"] == DBNull.Value ? 0 : (int)dr["AvailableCopies"],
                        BookImagePath = dr["BookImagePath"]?.ToString()


                    });
                }
            }
            return books;
        }
    }

    public class LibraryBook : Book
    {
        // Properties assumed to be defined here.
    }
}
