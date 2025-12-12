using System;
using System.Collections.Generic;
using System.IO;

class Client
{
    static void Main(string[] args)
    {
        //Black on white
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        //Read csv file into list
        List<Employee> lstEmployees = ReadFile();

        //Hard code selected supervisor number
        int supNumber = 7451;
        Supervisor sup = SupervisorFactory.lstSupervisors.Find(sp => sp.SupNumber == supNumber); //2
        Console.WriteLine("\tEmployees reporting to: " + sup.SupSurname);
        Console.WriteLine();

        //Print employees that report to this supervisor
        int i = 0;
        foreach (Employee employee in lstEmployees.FindAll(emp => emp.supervisor.SupNumber == supNumber))
        {
            Console.Write("\t" + (++i).ToString().PadLeft(3) + ".\t");
            Console.WriteLine(employee);
        }

        //Wait for user
        Console.ReadKey();
    } //Main

    private static List<Employee> ReadFile()
    {        
        string fileName = "StaffDetails.csv";
        List<string> lstLines = new List<string>(File.ReadAllLines(fileName));  //3

        //Remove header line
        lstLines.RemoveAt(0);                                                   //1

        //Add employees to list                                                 
        List<Employee> lstEmployees = new List<Employee>();
        foreach (string line in lstLines)                                       //9
        {
            string[] fields = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Supervisor supervisor = SupervisorFactory.GetSupervisor(int.Parse(fields[4]), fields[5], fields[6], DateTime.Parse(fields[7]));
            Employee employee = new Employee(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), fields[3], supervisor);
            lstEmployees.Add(employee);
        } //foreach line

        return lstEmployees;
    } //ReadFile
} //class Client

