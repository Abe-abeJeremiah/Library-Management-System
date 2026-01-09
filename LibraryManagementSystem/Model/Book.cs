using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public abstract class Book
    {
            public int BookID { get; set; }
            public string Title { get; set; }
            public string SubTitle { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public string ISBN { get; set; }
            public int PublicationYear { get; set; }
            public int AvailableCopies { get; set; }
            public string Publisher { get; set; }
            public string Edition { get; set; }
            public string Location { get; set; }
            public string Editor { get; set; }
            public string Language { get; set; }
            public string PhysicalDescription { get; set; }
            public string AccessionNumber { get; set; }

            // Optional if you store images
         
        public string BookImagePath { get; set; }
        public string Category { get; set; }
    }

    }



