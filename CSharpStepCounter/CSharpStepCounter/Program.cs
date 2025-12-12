using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the output of the title of the program
            Console.WriteLine("Welcome to the Daily Steps Tracker!");

            //declare the var to represent the steps taken
            int iSteps;

            //declare the var to represent the total num of steps taken and initialize it to 0 as the starting point
            int iTotalSteps = 0;

            //create a bool of continueTracking that is true to allow the loop to run
            bool continueTracking = true;

            //create a while loop accompanied by the condition of the bool
            while(continueTracking)
            {
                //prompt the user to enter the daily steps and convert to integers
                Console.Write("Enter your daily steps or type '-1' to finish: ");
                iSteps = int.Parse(Console.ReadLine());

                //create an if statement
                if(iSteps != -1)
                {
                    //sum the num of steps taken
                    iTotalSteps += iSteps;

                    //display the output
                    Console.WriteLine("Total steps so far today: " + iTotalSteps);
                }
                else
                {

                    //display the output
                    Console.WriteLine("Finishing up for today!");
                    //display the output
                    Console.WriteLine("Total steps for the day: " + iTotalSteps);

                    //if the bool is false, terminate the program
                    continueTracking = false;
                }
            }
            //display the window before closing
            Console.ReadKey();
        }
    }//main
}//class
