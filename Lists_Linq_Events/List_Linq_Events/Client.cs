using System;
using System.Collections.Generic;
using System.IO;

namespace Lists_Linq_Events
{
    internal class Client
    {
        static void Main(string[] args)
        {
            //Black on white
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Instantiate and initialise (also reading test data from file)
            List<Book> lstBooks = ReadFile("book_test_data.csv");

            Extensions.OnListEmpty += delegate () { Console.WriteLine("\tList is empty"); };

            //"AND"
            Console.WriteLine("\tList of books (AND criteria)");
            Console.WriteLine("\t============================");
            List<Book> lstBooks1 = lstBooks.Where(FieldName.Author, "Garcia")
                        .AND(lstBooks.Where(FieldName.Author, "Williams"))
                        .AND(lstBooks.Where(FieldName.Title, "Odyssey"));
            WriteBooks(lstBooks1.OrderBy(FieldName.Author));

            //Empty list
            Console.WriteLine("\tList of books by Motaung");
            Console.WriteLine("\t========================");
            List<Book> lstBooks2 = lstBooks.Where(FieldName.Author, "Motaung");
            WriteBooks(lstBooks2.OrderBy(FieldName.Title));

            //Exit program
            Console.Write("\n\tPress any key to exit... ");
            Console.ReadKey();
        } //Main

        private static List<Book> ReadFile(string fileName)
        {
            List<Book> lstBooks = new List<Book>();
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

                    lstBooks.Add(new Book(decimal.Parse(fields[1]), fields[2], authors));
                } //while !EndOfStream
            } //if file exists
            return lstBooks;
        } //Read

        private static void WriteBooks(List<Book> lstBooks)
        {
            foreach (Book book in lstBooks)
                Console.WriteLine("\t" + book);

            Console.WriteLine("\tNumber of books : " + lstBooks.Count);
            Console.WriteLine("\tTotal price     : " + lstBooks.TotalPrice().ToString("C"));
            //Console.WriteLine("\tAverage price   : " + lstBooks.AveragePrice().ToString("C"));
            Console.WriteLine();
        } //WriteBooks
    } //Client
} //namespace
