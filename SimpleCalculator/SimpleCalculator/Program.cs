using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyPractical_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCalculating = true;
            while(isCalculating)
            {
                
                Console.WriteLine("This is a simple calculator for calculating area or volume of rectangular objects.");
                Console.WriteLine("1. to calculate area \n2. to calculate volume");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                            {
                                Console.WriteLine("Provide the length of the object (in cm): ");
                                double dLength = double.Parse(Console.ReadLine());
                                Console.WriteLine("Provide the width of the object (in cm): ");
                                double dWidth = double.Parse(Console.ReadLine());
                                double dArea = Calculate(dLength, dWidth);
                                Console.WriteLine("The area of the object is " + dArea + " square cm");

                            }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Provide the length of the object (in cm): ");
                            double dLength2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Provide the width of the object (in cm): ");
                            double dWidth2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Provide the height of the object (in cm): ");
                            double dHeight = double.Parse(Console.ReadLine());
                            double dVolume = Calculate(dLength2, dWidth2, dHeight);
                            Console.WriteLine("The area of the object is " + dVolume + " cubic cm");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please read and understand your options asshole. Do the correct thing!");
                        }
                        break;
                }
                Console.Write("Type 1 to perform another calculation, type -1 to end your session: ");
                int i = int.Parse(Console.ReadLine());
                switch(i)
                {
                    case 1:
                        {
                            Console.Clear();
                        }
                        break;
                    case -1:
                        {
                            isCalculating = false;
                            Console.WriteLine("Thank you for using the calculator, press any key to exit.");
                            Console.WriteLine("OVER AND OUT!!!");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        static double Calculate( double length, double width)
        {
            return (length * width);
        }
        static double Calculate(double length2, double width2, double height)
        {
            return (length2 * width2 * height);
        }
    }
}
