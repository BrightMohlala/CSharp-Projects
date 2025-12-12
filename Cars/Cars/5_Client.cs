//Example adapted from Kumar, https://www.c-sharpcorner.com/article/factory-design-pattern-real-world-example/
//Follows the Factory method pattern

using System;

class Client
{
    static void Main(string[] args)
    {
        //Instance of Creator class
        ACarFactory factoryHonda = new HondaFactory();

        //Instance of product
        ICar car1 = factoryHonda.MakeCar("CRV", "Red");
        Console.WriteLine("Model is " + car1.GetCarModel());
        Console.WriteLine("Colour is " + car1.CarColor);

        Console.WriteLine();

        //Instance of Creator
        ACarFactory factoryBMW = new BMWFactory();

        //Instance of product
        ICar car2 = factoryBMW.MakeCar("3 series", "White");
        Console.WriteLine("Model is " + car2.GetCarModel());
        Console.WriteLine("Colour is " + car2.CarColor);

        Console.ReadLine();
    } //Main
} //class Client

