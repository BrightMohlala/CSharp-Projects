
using System;
using System.Collections.Generic;
using System.IO;

namespace CT8Q3_TM
{
    internal class Client
    {       
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Timer
            CTimer timer = new CTimer(1);

            //Context 
            timer.Start();
            string[] entries = ReadEntries();
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();
            timer.Stop();
          
            //Remove by creating a new array
            entries = ReadEntries();
            timer.Start();
            ARemove<string> remove = new Remove_by_temp_array<string>();
            remove.RemoveEntry(ref entries, "aanbeveel");
            timer.Stop();
            Console.WriteLine("\tRemove by new array          : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();

            //Remove by replacement
            entries = ReadEntries();
            timer.Start();
            remove = new Remove_by_replace<string>();
            remove.RemoveEntry(ref entries, "aanbeveel");
            timer.Stop();
            Console.WriteLine("\tRemove by replacement        : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();

            //Remove by conversion to list
            entries = ReadEntries();
            timer.Start();
            remove = new Remove_by_conversion<string>();
            remove.RemoveEntry(ref entries, "aanbeveel");
            timer.Stop();
            Console.WriteLine("\tRemove by conversion to list : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);

            //Exit program
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        //Read entries
        private static string[] ReadEntries()
        {
            string[] entries = new string[20000];
            StreamReader f = new StreamReader("Dictionary.txt");
            int i = -1;
            while (!f.EndOfStream)
            {
                i++;
                string s = f.ReadLine() + "\t";
                entries[i] = s.Split('\t')[0];
            }
            f.Close();
            Array.Resize(ref entries, i + 1); //Make smaller to get rid of unnecessary reserved space
            return entries;
        } //ReadEntries


    } //class Client
} //namespace
