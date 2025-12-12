using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lists_Linq_Events
{
    internal class Books
    {
        private List<Book> lstBooks = new List<Book>();

        public Books()
        {
            ReadFile("book_test_data.csv");
        } //ctor

        ///// <summary>
        ///// Returns a list of books based on a specific set of criteria
        ///// </summary>
        ///// <param name="title">Case insensitive partial title to include in result.</param>
        ///// <param name="author">Case insensitive partial author to include in result.</param>
        ///// <param name="isbn">Exact ISBN to include in search. Leave out or type "All" to include all ISBNs.</param>
        ///// <returns>List of books for which the search criteria apply.</returns>
        //public List<Book> ListBooks(string title= "All", string author = "All", string isbn = "All")
        //{
        //    List<Book> filteredList = lstBooks;
        //    if (isbn != "All" && isbn != "")
        //        filteredList = filteredList.Intersect(lstBooks.Where(book => book.ISBN == isbn)).ToList();
        //    if (author != "All" && author != "")
        //        filteredList = filteredList.Intersect(lstBooks.Where(book => book.Authors.ToUpper().Contains(author.ToUpper()))).ToList();
        //    if (title != "All" && title != "")
        //        filteredList = filteredList.Intersect(lstBooks.Where(book => book.Title.ToUpper().Contains(title.ToUpper()))).ToList();

        //    return filteredList;
        //} //ListBooks

        public List<Book> List()
        {
            return lstBooks;
        }

        //public List<Book> ListBooksAll(string[] details)
        //{
        //    List<Book> filteredList = lstBooks.Where(book => details.All((book.Authors + book.Title).Contains)).ToList();
        //    return filteredList;
        //} //ListBooksAll

        //public List<Book> ListBooksAny(string[] details)
        //{
        //    List<Book> filteredList = lstBooks.Where(book => details.Any((book.Authors + book.Title).Contains)).ToList();
        //    return filteredList;
        //} //ListBooksAny

        private void ReadFile(string fileName)
        {
            lstBooks = new List<Book>();
            if (File.Exists(fileName))
            {
                using StreamReader f = new StreamReader(fileName);
                f.ReadLine(); // Titles;
                while (!f.EndOfStream)
                {
                    string[] fields = f.ReadLine().Replace("\"", "").Split(',');
                    string isbn = fields[0].Substring(1, fields[0].Length - 2).PadLeft(13, '0');
                    string authors = "";
                    for (int i = 3; i < Math.Min(7, fields.Length); i++)
                        authors += fields[i] + ", ";
                    authors = authors.Substring(0, authors.Length - 2);

                    lstBooks.Add(new Book(isbn.PadLeft(13, '0'), decimal.Parse(fields[1]), fields[2], authors));
                } //while !EndOfStream
            } //if file exists
        } //Read

    } //class Books
} //namespace
