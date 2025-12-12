using System;
using System.Collections.Generic;
using System.Linq;

namespace Prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Black on white
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Data handling
            string[][] content = FileManagement.Read("Books.tsv");
            List<Book> books = ExtractData(content);
            ShowBooks(books, 10);
            List<Author> lstAuthors = CreateSummary(books);
            ShowSummary(lstAuthors);
            SaveSummary(lstAuthors);

            //Read output
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static List<Book> ExtractData(string[][] content)
        {
            List<Book> books = new List<Book>();
            for (int i = 1; i < content.Length; i++) //First line is header line
            {
                if (content[i].Length == 4)
                {
                    Book book = new   Book(content[i][0] + ", " + content[i][1], content[i][2], decimal.Parse(content[i][3]));
                    books.Add (book);
                }
            }
            return books;
        } //ExtractData

        private static void ShowBooks(List<Book> books, int n)
        {
            Console.WriteLine("\t" + "Surname, Initials".PadRight(20, ' ') + "\t" + "Title".PadRight(25, ' ') + "\t" + "Price");
            Console.WriteLine("\t" + "".PadRight(20, '=') + "\t" + "".PadRight(25, '=') + "\t" + "=====");
            for (int i = 0; i < n; i++)
            {
                Book book = books[i];
                Console.WriteLine("\t" + book.SurnameInitials.PadRight(20, ' ') + "\t" + book.Title.PadRight(25, ' ') + "\t" + book.Price.ToString().PadLeft(5, ' '));
            }
        } //ShowBooks

        private static List<Author> CreateSummary(List<Book> books)
        {
            List<Author> lstAuthors = new List<Author>();

            foreach (Book book in books)
            {
                Author author = lstAuthors.FirstOrDefault(a => a.SurnameInitials == book.SurnameInitials);
                if (author == null) //Author not yet in the list
                    lstAuthors.Add(new Author(book.SurnameInitials, 1, book.Price));
                else //Author already in the list - increment values
                {
                    author.NumberOfBooks++;
                    author.TotalPrice += book.Price;
                }
            } //foreach

            return lstAuthors;

        } //CreateSummary

        private static void ShowSummary(List<Author> authors)
        {
            Console.WriteLine();
            Console.WriteLine("\t" + "Surname, Initials".PadRight(20, ' ') + "\t" + "NumOfBooks" + "\t" + "Total price");
            Console.WriteLine("\t" + "".PadRight(20, '=') + "\t" + "".PadRight(7, '=') + "\t" + "===========");

            var authors_ = authors.Where(a => a.NumberOfBooks >= 5).OrderByDescending(a => a.NumberOfBooks);
            foreach (Author author in authors_)
            {
                Console.WriteLine("\t" + author.SurnameInitials.PadRight(20, ' ')
                                + "\t" + author.NumberOfBooks.ToString().PadLeft(5, ' ')
                                + "\t  " + author.TotalPrice.ToString().PadLeft(6, ' '));
            }
        } //ShowSummary

        private static void SaveSummary(List<Author> authors)
        {
            string[][] content = new string[authors.Count][];
            for (int i = 0; i < authors.Count; i++)
            {
                Author author = authors[i];
                content[i] = new string[3];
                content[i][0] = author.SurnameInitials;
                content[i][1] = author.NumberOfBooks.ToString();
                content[i][2] = author.TotalPrice.ToString();
            } //for i

            if (FileManagement.Save("Summary.tsv", content))
                Console.WriteLine("\n\tSummary saved");
            else
                Console.WriteLine("\n\tCould not save summary");
            Console.WriteLine();
        } //SaveSummary

    } //class
} //namespace
