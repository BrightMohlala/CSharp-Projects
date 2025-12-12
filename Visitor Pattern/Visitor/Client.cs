
using System;

namespace CT9Q2_Visitor
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Consoe.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("\tCar 1 instantiated and registered");
            Car car1 = new Car();
            Register_Visitor rv1 = new Register_Visitor("ABC123FS");
            Print_Visitor pv = new Print_Visitor();
            car1.AcceptVisitor(rv1);
            car1.AcceptVisitor(pv);

            Console.WriteLine("\tCar 1 driven 200 km");
            Drive_Visitor dv = new Drive_Visitor(200);
            car1.AcceptVisitor(dv);
            car1.AcceptVisitor(pv);

            Console.WriteLine("\tCar 2 instantiated and registered");
            Car car2 = new Car();
            Register_Visitor rv2 = new Register_Visitor("DEF456FS");
            car2.AcceptVisitor(rv2);
            car2.AcceptVisitor(pv);

            Console.WriteLine("\tCar 2 driven 400 km");
            Drive_Visitor dv2 = new Drive_Visitor(400);
            car2.AcceptVisitor(dv2);
            car2.AcceptVisitor(pv);

            Console.WriteLine("\tCar 2 driven 300 km");
            Drive_Visitor dv3 = new Drive_Visitor(300);
            car2.AcceptVisitor(dv3);
            car2.AcceptVisitor(pv);

            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main
    } //class Client
} //namespace
