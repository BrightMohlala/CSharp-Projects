
using System;

namespace CT9Q2_Visitor
{
    public class Register_Visitor : IVisitor
    {
        string registration;

        //public Register_Visitor(string registration) => this.registration = registration;
        public Register_Visitor(string registration) 
        {
            this.registration = registration;
        }//ctor

        public void Visit(Car car)
        {
            car.Registration = registration;
        }//Visit

    } //Register_Visitor

    public class Drive_Visitor : IVisitor
    {
        int kilometres = 0;
        public Drive_Visitor(int kilometres)
        {
            this.kilometres = kilometres;
        }//ctor

        public void Visit(Car car)
        {
            car.Odometer += kilometres;
        }//Visit

    } //Drive_Visitor

    public class Print_Visitor : IVisitor
    {
        public void Visit(Car car)
        {
            Console.WriteLine("\tRegistration : " + car.Registration);
            Console.WriteLine("\tOdometer     : " + car.Odometer);
            Console.WriteLine();
        } //Visit

    } //Print_Visitor

} //namespace
