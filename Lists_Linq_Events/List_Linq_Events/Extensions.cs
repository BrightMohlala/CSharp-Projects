using System.Collections.Generic;
using System.Linq;

namespace Lists_Linq_Events
{
    public delegate void delOnListEmpty ();

    public static class Extensions
    {
        /// <summary>
        /// Event raised when a list is empty.
        /// </summary>
        public static event delOnListEmpty OnListEmpty;

        /// <summary>
        /// Calculates the total price of books in a given list.
        /// </summary>
        /// <param name="lstBooks">List of books</param>
        /// <returns>Total price of books in the list.</returns>
        public static decimal TotalPrice(this List<Book> lstBooks)
        {
            if (lstBooks.Count > 0)
            {
                return lstBooks.Sum(book => book.Price);
            }
            else
            {
                return 0;
            }
        } //TotalPrice

        /// <summary>
        /// Calculates the average price of books in a given list.
        /// </summary>
        /// <param name="lstBooks">List of books</param>
        /// <returns>Average price of books in the list.</returns>
        //public static decimal AveragePrice(this List<Book> lstBooks)
        //{
        //    if (lstBooks.Count > 0)
        //        return lstBooks.Average(book => book.Price);
        //    return 0;
        //} //AveragePrice

        /// <summary>
        /// Filters the list of books based on a given field name and value.
        /// </summary>
        /// <param name="lstBooks">The list of books to be filtered.</param>
        /// <param name="fieldName">The field name on which to base the filter.</param>
        /// <param name="fieldValue">The value for the specified field name</param>
        /// <returns>The filtered list of books.</returns>
        public static List<Book> Where(this List<Book> lstBooks, FieldName fieldName, string fieldValue)
        {
            List<Book> filteredList = lstBooks;
            if (fieldName == FieldName.Author)
            {
                filteredList = lstBooks.Where(book => book.Authors.ToUpper().Contains(fieldValue.ToUpper())).ToList();
            }
                 
            if (fieldName == FieldName.Title)
            {
                filteredList = lstBooks.Where(book => book.Title.ToUpper().Contains(fieldValue.ToUpper())).ToList();
            }
                
            //filteredList = lstBooks.Where(book => fieldName.ToString().ToUpper().Contains(fieldValue.ToUpper())).ToList();

            if (filteredList.Count == 0)
            {
                OnListEmpty?.Invoke();
            }
              
            return filteredList;
        } //Where

        /// <summary>
        /// Returns a list of books combined (joined) with another list
        /// </summary>
        /// <param name="lstBooks1">First list of books</param>
        /// <param name="lstBooks2">Second list of books</param>
        /// <returns>Combination of first and second list of books without duplicates.</returns>
        //public static List<Book> OR(this List<Book> lstBooks1, List<Book> lstBooks2)
        //{
        //    return lstBooks1.Union(lstBooks2).ToList();
        //} //OR

        /// <summary>
        /// Returns a list of books that are contained in both of two lists.
        /// </summary>
        /// <param name="lstBooks1">First list of books</param>
        /// <param name="lstBooks2">Second list of books</param>
        /// <returns>List of books that appear in both lists.</returns>
        public static List<Book> AND(this List<Book> lstBooks1, List<Book> lstBooks2)
        {
            List<Book> lstbooks = lstBooks1.Intersect(lstBooks2).ToList(); 
            return lstbooks;
        } //AND

        /// <summary>
        /// Returns a list of books ordered by the specified field name
        /// </summary>
        /// <param name="lstBooks">The list of books to be sorted.</param>
        /// <param name="orderBy">The field name on which the books must be sorted.</param>
        /// <returns>The sorted list of books.</returns>
        public static List<Book> OrderBy(this List<Book> lstBooks, FieldName orderBy)
        {
            List<Book> sortedList = lstBooks;

            if (orderBy == FieldName.Author)
            {
                sortedList = lstBooks.OrderBy(book => book.Authors).ToList();
            }
                
            if (orderBy == FieldName.Title)
            {
                sortedList = lstBooks.OrderBy(book => book.Title).ToList();
            }
                
            //sortedList = lstBooks.OrderBy(book => orderBy).ToList();

            return sortedList;
        } //OrderBy

        /// <summary>
        /// Returns a list of books ordered in descending order by the specified field name
        /// </summary>
        /// <param name="lstBooks">The list of books to be sorted.</param>
        /// <param name="orderBy">The field name on which the books must be sorted.</param>
        /// <returns>The list of books in descending order.</returns>
        //public static List<Book> OrderByDesc(this List<Book> lstBooks, FieldName orderBy)
        //{
        //    lstBooks = lstBooks.OrderBy(orderBy);
        //    lstBooks.Reverse();
        //    return lstBooks;
        //}
    } //class Extensions
} //namespace
