using System;

namespace Question1
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

            //1.3.2 Create the tree
            Tree<string> tree = CreateTree();

            //1.3.3 BFT
            Console.WriteLine("\tBreadth-first traversal:");
            Console.WriteLine("\t" + string.Join(", ", tree.BFT()));
            Console.WriteLine();

            //1.3.4 DFT
            Console.WriteLine("\tDepth-first traversal:");
            Console.WriteLine("\t" + string.Join(", ", tree.DFT()));
            Console.WriteLine();

            //Exit program
            Console.WriteLine("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        //1.3.2
        private static Tree<string> CreateTree()
        {
            //Create the nodes in breadth-first order
            Tree<string> john = new Tree<string>("John");
            Tree<string> susan = new("Susan"); Tree<string> chris = new("Chris");
            Tree<string> david = new("David"); Tree<string> emily = new("Emily"); Tree<string> sarah = new("Sarah"); Tree<string> jane = new("Jane");
            Tree<string> alex = new("Alex"); Tree<string> emma = new("Emma"); Tree<string> hazel = new("Hazel"); Tree<string> basil = new("Basil");
            Tree<string> jackie = new("Jackie"); Tree<string> pippa = new("Pippa"); Tree<string> riley = new("Riley"); Tree<string> viera = new("Viera");
            
            //Connect the nodes using the AddChildren method
            john.AddChildren([susan, chris]);
            susan.AddChildren(new Tree<string>[] { david, emily });
            chris.AddChildren(new Tree<string>[] { sarah, jane });
            emily.AddChildren(new Tree<string>[] { alex, emma });
            jane.AddChildren(new Tree<string>[] { hazel, basil });
            emma.AddChildren(new Tree<string>[] { jackie, pippa, riley, viera });

            //Return the root
            return john;
        } //CreateTree

    } //class Client
} //namespace
