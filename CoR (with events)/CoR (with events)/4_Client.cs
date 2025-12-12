using System;

namespace CT5Q1_CoR
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Set up CoR
            //- Handlers
            IHandler R50 = new R50();  R50.OnHandle += Client_OnHandle;
            IHandler R10 = new R10();  R10.OnHandle += Client_OnHandle;
            IHandler R5 = new R5();    R5.OnHandle += Client_OnHandle;
            IHandler R1 = new R1();    R1.OnHandle += Client_OnHandle;
            IHandler c50 = new c50();  c50.OnHandle += Client_OnHandle;
            IHandler c20 = new c20();  c20.OnHandle += Client_OnHandle;
            IHandler c10 = new c10();  c10.OnHandle += Client_OnHandle;
            IHandler c1 = new c1();    c1.OnHandle += Client_OnHandle;
            //- Succesors
            R50.SetSuccessor(R10);
            R10.SetSuccessor(R5);
            R5.SetSuccessor(R1);
            R1.SetSuccessor(c50);
            c50.SetSuccessor(c20);
            c20.SetSuccessor(c10);
            c10.SetSuccessor(c1);

            //Get input
            decimal purchase = GetAmount("\tAmount purchased: ");
            decimal rendered = GetAmount("\tAmount rendered : ");

            //Calculate change
            decimal change = rendered - purchase;
            Console.WriteLine ("\tChange          : " + change.ToString("C") );

            //Show denominations
            Console.WriteLine();
            R50.ProcessRequest((int)(change * 100));

            //Wait for user
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static void Client_OnHandle(string response)
        {
            Console.WriteLine("\t" + response);
        } //Client_OnHandle

        private static decimal GetAmount(string prompt)
        {
            decimal amount = 0;
            Console.Write(prompt);
            while (!decimal.TryParse(Console.ReadLine(), out amount))
                Console.Write(prompt);
            return amount;
        } //GetAmount

    } //class Client
} //namespace
