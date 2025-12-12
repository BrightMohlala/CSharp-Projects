using System;

namespace StudentTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the CSIS student GPA tracker. \nPlease provide the necessary student details.");
                students[i] = new Student();

                Console.WriteLine($"Details for student {i + 1}: ");
                Console.Write("Name of student: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Age of student: ");
                students[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Current GPA of student: ");
                students[i].GPA = double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("List of students: ");
            foreach (var student in students) 
            {
                student.DisplayStudentInfo();            
            }

            Console.Write("Press any key to exit");
            Console.ReadKey();

        }
    }
}