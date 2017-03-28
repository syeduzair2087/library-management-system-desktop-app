using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public static class General
    {
        public static List<Member> Members = new List<Member>();
        public static List<Book> Books = new List<Book>();
        public static List<Book> AvailableBooks = new List<Book>();

        public static void Load_Data()
        {

            if (File.Exists("BooksDB.txt"))
            {
                StreamReader BookLoad = new StreamReader("BooksDB.txt");
                string CurrentBook = BookLoad.ReadLine();

                while (CurrentBook != null)
                {
                    if (CurrentBook.StartsWith("#BOOK"))
                    {
                        string BookId = CurrentBook = BookLoad.ReadLine();
                        string BookName = CurrentBook = BookLoad.ReadLine();
                        string BookAuthor = CurrentBook = BookLoad.ReadLine();
                        Book LoadBook = new Book(BookId, BookName, BookAuthor);
                        Books.Add(LoadBook);
                    }

                    CurrentBook = BookLoad.ReadLine();
                }

                BookLoad.Close();
            }


            if (File.Exists("MembersDB.txt"))
            {
                StreamReader MemberLoad = new StreamReader("MembersDB.txt");
                string CurrentMember = MemberLoad.ReadLine();

                while (CurrentMember != null)
                {
                    if (CurrentMember.StartsWith("#MEMBER"))
                    {
                        Member LoadMember = new Member(CurrentMember.Substring(7));
                        Members.Add(LoadMember);

                        CurrentMember = MemberLoad.ReadLine();

                        if (CurrentMember == null)
                            break;

                        while (CurrentMember.StartsWith(":"))
                        {
                            string Id = CurrentMember.Substring(1);

                            foreach (Book b in Books)
                            {
                                if (Id == b.BookID)
                                {
                                    LoadMember.booksBorrowed.Add(b);
                                    break;
                                }
                            }

                            CurrentMember = MemberLoad.ReadLine();

                            if (CurrentMember == null)
                                break;
                        }

                    }
                }

                MemberLoad.Close();

            }


        }




        public static void SaveData()
        {
            StreamWriter MemberSave = new StreamWriter("MembersDB.txt");

            foreach (Member m in Members)
            {
                MemberSave.WriteLine("#MEMBER" + m.Name);

                foreach (Book bb in m.booksBorrowed)
                {
                    MemberSave.WriteLine(":" + bb.BookID);
                }
            }

            MemberSave.Close();

            StreamWriter BookSave = new StreamWriter("BooksDB.txt");

            foreach (Book b in Books)
            {
                BookSave.WriteLine("#BOOK");
                BookSave.WriteLine(b.BookID);
                BookSave.WriteLine(b.BookName);
                BookSave.WriteLine(b.Author);
            }

            BookSave.Close();
        }

        public static List<Book> GetAvailableBooks(Member m)
        {

            if (m.booksBorrowed.Count > 0)
            {
                AvailableBooks.Clear();


                foreach (Book b in General.Books)
                {
                    if (!(m.booksBorrowed.Contains(b)))
                        AvailableBooks.Add(b);
                }

                return AvailableBooks;
            }

            else
                return Books;
        }

    }

}