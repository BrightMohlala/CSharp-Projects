using System;

class Client
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        MPFacade mp = new MPFacade();

        Console.WriteLine("\tPress a command (P/U/S/X).");
        Console.Write("\t");

        char option;
        while (true)
        {
            option = char.ToUpper(Console.ReadKey().KeyChar);
            switch (option)
            {
                case 'P': mp.Play(); break;
                case 'U': mp.Pause(); break;
                case 'S': mp.Stop(); break;
                case 'X': Environment.Exit(0); break;
            } //switch

        } //while

    } //Main
}

