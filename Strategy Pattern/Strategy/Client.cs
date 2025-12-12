
using System;
using System.Collections.Generic;
using System.IO;

namespace CT8Q2_Strategy
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
            //KeyValuePair<string, string>[] kv_entries = ReadEntries();
            string[] kv_entries = ReadEntries2();
            //Entries<KeyValuePair<string, string>> entries = new Entries<KeyValuePair<string, string>>(kv_entries);
            Entries<string> entries = new Entries<string>(kv_entries);
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();
            timer.Stop();

            //Strategies
            //IRemoveStrategy<KeyValuePair<string, string>> remove_by_replacing = new Remove_by_replace<KeyValuePair<string, string>>();
            //IRemoveStrategy<KeyValuePair<string, string>> remove_by_new_array = new Remove_by_temp_array<KeyValuePair<string, string>>();
            //IRemoveStrategy<KeyValuePair<string, string>> remove_by_convert_list = new Remove_by_conversion<KeyValuePair<string, string>>();
            IRemoveStrategy<string> remove_by_replacing = new Remove_by_replace<string>();
            IRemoveStrategy<string> remove_by_new_array = new Remove_by_temp_array<string>();
            IRemoveStrategy<string> remove_by_convert_list = new Remove_by_conversion<string>();


            //Remove by replacement
            entries.SetRemoveStrategy(remove_by_replacing);
            timer.Start();
            entries.RemoveAt(300);
            timer.Stop();
            Console.WriteLine("\tRemove by replacement        : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();

            //Remove by creating a new array
            entries = new Entries<string>(kv_entries);
            entries.SetRemoveStrategy(remove_by_new_array);
            timer.Start();
            entries.RemoveAt(300);
            timer.Stop();
            Console.WriteLine("\tRemove by new array          : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);
            Console.WriteLine();

            //Remove by conversion to list
            entries = new Entries<string>(kv_entries);
            entries.SetRemoveStrategy(remove_by_convert_list);
            timer.Start();
            entries.RemoveAt(300);
            timer.Stop();
            Console.WriteLine("\tRemove by conversion to list : " + timer.msDuration.ToString("0.00") + " ms");
            Console.WriteLine("\tNumber of entries            : " + entries.Length);

            //Exit program
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        //Read entries
        private static KeyValuePair<string, string>[] ReadEntries()
        {
            KeyValuePair<string, string>[] entries = new KeyValuePair<string, string>[20000];
            StreamReader f = new StreamReader("Dictionary.txt");
            int i = -1;
            while (!f.EndOfStream)
            {
                i++;
                string s = f.ReadLine() + "\t";
                entries[i] = new KeyValuePair<string, string>(s.Split('\t')[0], s.Split('\t')[1]);
            }
            f.Close();
            Array.Resize(ref entries, i + 1); //Make smaller to get rid of unnecessary reserved space
            return entries;
        } //ReadEntries

        //Read entries
        private static string[] ReadEntries2()
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
