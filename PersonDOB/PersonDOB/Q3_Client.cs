using System;


internal class Client
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        //Person 1
        IPerson person1 = new Person("Mokoena", "Joshua", "0203310084083");
        PersonDecorator dp1 = new PersonDecorator(person1);

        Console.WriteLine("\tName    : " + dp1.Name);
        Console.WriteLine("\tSurname : " + dp1.Surname);
        Console.WriteLine("\tID      : " + dp1.ID_number);
        Console.WriteLine("\tDOB     : " + dp1.DOB.ToString("yyyy-MM-dd"));
        Console.WriteLine();

        //Person 2
        IPerson person2 = new Person("Matthews", "Mike", "8107310082072");
        PersonDecorator dp2 = new PersonDecorator(person2);

        Console.WriteLine("\tName    : " + dp2.Name);
        Console.WriteLine("\tSurname : " + dp2.Surname);
        Console.WriteLine("\tID      : " + dp2.ID_number);
        Console.WriteLine("\tDOB     : " + dp2.DOB.ToString("yyyy-MM-dd"));


        Console.Write("\n\tPress any key to exit ...");
        Console.ReadKey();    
    } //Main
} //class

