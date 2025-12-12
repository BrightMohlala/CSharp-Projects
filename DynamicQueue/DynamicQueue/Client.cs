using Playground_queue;
using System;
using System.IO;

namespace PlaygroundQ
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Prepare output file
            string path = "output.txt";
            FileAttributes attributes = File.GetAttributes(path);
            attributes &= ~FileAttributes.ReadOnly;
            File.SetAttributes(path, attributes);
            File.Delete("output.txt");

            //Instantiate 
            IQueue<Toddler> toddlerQ = new DynamicQueue<Toddler>();

            //Add test data
            AddTestData(toddlerQ);
            Console.WriteLine("\tInitial test data");
            ListAll(toddlerQ); Console.WriteLine();

            //Insert by position
            InsertByPosition(toddlerQ);
            Console.WriteLine("\tAll toddlers after some inserted by position");
            ListAll(toddlerQ); Console.WriteLine();

            //Insert somewhere
            InsertByName(toddlerQ);
            Console.WriteLine("\tAll toddlers after some inserted by name");
            ListAll(toddlerQ); Console.WriteLine();

            //Remove by name
            toddlerQ = toddlerQ.Remove("Mpho");
            Console.WriteLine("\tAll toddlers after Mpho removed");
            ListAll(toddlerQ); Console.WriteLine();

            //Clear screen before start sliding
            Console.Write("\tPress any key to start sliding ... ");
            Console.ReadKey(); Console.Clear();
            File.AppendAllText("output.txt", "\nStart sliding\n");

            //Start sliding
            int n = 1;
            while (!toddlerQ.IsEmpty()) //Use (toddlerQ.Count > 0) if you cannot get IsEmpty() to work
            {
                Toddler toddler = toddlerQ.Dequeue();
                toddler.OnAssistanceNeeded -= Assistance;
                toddler.OnAssistanceNeeded += Assistance;
                toddler.Slide();
                Console.WriteLine("\t" + toddler + " slided down. Remaining toddlers: " + toddlerQ.Count);
                File.AppendAllText("output.txt", "\n" + toddler + " slided down.\n");
                ListAll(toddlerQ);

                //Randomly let a toddler run around and join the queue again
                //if (new Random((int)DateTime.Now.Ticks).Next(0, 2) == 1)
                if (n % 3 == 0)
                {
                    toddlerQ.Enqueue(toddler);
                    Console.WriteLine("\t" + toddler + " joined the queue again. Remaining toddlers: " + toddlerQ.Count);
                    File.AppendAllText("output.txt", "\n" + toddler + " joined the queue again.\n");
                    ListAll(toddlerQ);
                } //if
                Console.WriteLine();

                //Wait before next toddler
                System.Threading.Thread.Sleep(1000);
                n++;
            } //while (toddlerQ.Count > 0)

            //Read output
            File.AppendAllText("output.txt", "\nQueue is empty\n");
            File.SetAttributes("output.txt", FileAttributes.ReadOnly);
            Console.Write("\tQueue is empty. Press any key to exit ... ");
            Console.ReadKey();

        } //Main

        private static void Assistance(Toddler toddler)
        {
            Console.WriteLine("\t" + toddler.Name + " needs assistance.");
        } //Assistance

        private static void AddTestData(IQueue<Toddler> toddlers)
        {
            toddlers.Enqueue(new Toddler("Dineo", Skill.Good)); 
            toddlers.Enqueue(new Toddler("Joele", Skill.Inept)); 
            toddlers.Enqueue(new Toddler("Mpho", Skill.Decent));

        } //AddTestData

        private static void InsertByPosition(IQueue<Toddler> toddlers)
        {
            toddlers.InsertAt(new Toddler("Ben", Skill.Decent), 0); //Insert in the beginning
            toddlers.InsertAt(new Toddler("Endy", Skill.Inept), toddlers.Count); //Insert at the end
        } //InsertBPosition

        private static void InsertByName(IQueue<Toddler> toddlers)
        {
            toddlers.InsertBefore(new Toddler("Abel", Skill.Decent), "Ben"); //Insert Abel before Ben
            toddlers.InsertBefore(new Toddler("Impy", Skill.OK), "Endy"); //Insert Impy before Endy
        } //InsertData

        private static void ListAll(IQueue<Toddler> toddlers)
        {
            Console.Write("\tQ: ");
            Console.WriteLine(String.Join(", ", toddlers.ToList()));
            File.AppendAllText("output.txt", "Q: " + String.Join(", ", toddlers.ToList()) + "\n");

            //Use this if you cannot get ToList to work
            //foreach (Toddler t in toddlers)
            //    Console.Write(t.ToString() + ", ");
        } //ListData
    } //class Client
}  //namespace
