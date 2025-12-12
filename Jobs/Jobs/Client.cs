/* Class Client:
   - This is just a test class. 
     - Company and default car details are hard coded for test purposes. 
       In a production environment, the user should be asked to enter these values.
     - Also, jobs are hard coded and added to the list of jobs. In a production environment, a menu driven application should be used 
       to add jobs as requested by the user.
 */

using System;
using System.Linq;

static class Client
{
    //Data members
    private static Company company;
    private static IJob templateJob;

    //Main
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        //Register company
        company = Company.GetInstance("Johnny's Auto Shop", "12 Church street, Bloemfontein", "051 123 4567");

        //Template job with default car
        Car defaultCar = new Car("", "Toyota", "Corolla", 0);
        templateJob = new Job(0, defaultCar);

        //Add jobs
        AddJobs();

        //Proceed to output
        Output();

        //Close program
        Console.Write("\tPress any key to exit ...");
        Console.ReadKey();
    } //Main

    static void AddJobs()
    {
        //- Job with default car
        IJob job1 = templateJob.Clone(company.Jobs().Count() + 1);
        Car vehicle = job1.GetCar();
        vehicle.SetRegistration("DEF 456 FS");
        vehicle.SetOdo(20000);
        company.AddJob(job1);

        //- Job with alternative car details
        IJob job2 = templateJob.Clone(company.Jobs().Count() + 1);
        job2.SetCar("GHI 789 FS", "Honda", "Ballade", 30000);
        company.AddJob(job2);
    } //AddJobs

    static void Output()
    {
        Console.Clear();
        Console.WriteLine();
        foreach (IJob job in company.Jobs())
        {
            Console.WriteLine(job.ToString());
        } //foreach job
    } //Output
}//class


