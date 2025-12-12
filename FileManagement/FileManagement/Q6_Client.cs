using System;

class Client
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        IFileManagement px1 = new FMProxy("ProxyDemo.txt");
        px1.Write("\tabc");
        string s = px1.Read();
        Console.WriteLine(s);

        IFileManagement px2 = new FMProxy("ProxyDemo2.txt");
        s = px2.Read();
        Console.WriteLine(s);

        //Wait to read
        Console.Write("\n\tPress any key to exit ...");
        Console.ReadKey();
    } //Main
} //class Client

