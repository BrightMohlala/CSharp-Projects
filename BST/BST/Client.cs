using System;
using System.Collections.Generic;

namespace Question2
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Read data
            List<char> lstChars = new List<char>();
            lstChars.AddRange(new char[] { 'G', 'N', 'P', 'A', 'T', 'H', 'D', 'J', 'E', 'C' });

            //Use a binary search tree
            BST bst = GetBST(lstChars);
            Console.WriteLine("\tBFT        : " + String.Join(", ", bst.BFT()));
            Console.WriteLine("\tPre-order  : " + String.Join(", ", bst.VisitPreOrder()));
            Console.WriteLine("\tIn-order   : " + String.Join(", ", bst.VisitInOrder()));
            Console.WriteLine("\tPost-order : " + String.Join(", ", bst.VisitPostOrder()));

            //Exit program
            Console.Write("\n\tPress any key to exit ... ");
            Console.ReadKey();
        } //Main

        private static BST GetBST(List<char> lstChars)
        {
            BST bst = new BST(lstChars[0]);
            for (int i = 1; i < lstChars.Count; i++)
                bst.Add(lstChars[i]);

            return bst;
        } //GetBST


    } //class Client
} //namespace
