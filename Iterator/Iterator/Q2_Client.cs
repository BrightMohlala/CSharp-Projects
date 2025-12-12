using System;

namespace CT6_Q1_Iterator_b
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Create queue
            IQueue<string> qNames = new DynamicQueue<string>();

            //Enqueue some test data
            qNames.Enqueue("Mike");
            qNames.Enqueue("Thabo");
            qNames.Enqueue("Lily");
            qNames.Enqueue("Susan");
            qNames.Enqueue("Mary");

            //Test dequeue
            qNames.Dequeue();

            //Enqueue more items
            qNames.Enqueue("John");
            qNames.Enqueue("Peter");
            qNames.Enqueue("Hendrik");
            qNames.Enqueue("Kgomotso");

            //Peek element
            Console.WriteLine("\tFirst name: " + qNames.Peek());

            //Step through names without dequeueing
            ListAll(qNames);

            //Dequeue
            Console.WriteLine("\n\tFirst name dequeued: " + qNames.Dequeue());

            //Step through names without dequeueing
            ListAll(qNames);

            //Exit program
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static void ListAll(IQueue<string> qNames)
        {
            Console.WriteLine("\n\tAll names in queue:");
            IIterator<string> iterator = qNames.CreateIterator();
            iterator.First();
            Console.Write("\t");
            while (iterator.Current != null)
            {
                Console.Write(iterator.Current);
                iterator.Next();
                if (iterator.Current != null)
                    Console.Write(", ");
            }
            Console.WriteLine();

        } //ListAll

    } //class
} //namespace
