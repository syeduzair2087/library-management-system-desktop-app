using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Book
    {
        private static int iDCounter = 1;
        private string bookID;
        private string bookName;
        private string author;

        public string BookID
        {
            get
            {
                return bookID;
            }
        }

        public string BookName
        {
            get
            {
                return bookName;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }


        public Book(string BookName, string BookAuthor)
        {
            bookID = "LB-" + Convert.ToString(iDCounter);
            bookName = BookName;
            author = BookAuthor;
            iDCounter++;
        }

        public Book(string Id, string BookName, string BookAuthor)
        {
            bookID = Id;
            bookName = BookName;
            author = BookAuthor;
            iDCounter++;
        }
    }

}
