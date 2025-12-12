using System;

namespace CT5Q2_CoR
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Handle input
            string s_input = "123";
            var input = GetValue(s_input); //dynamic assigned to anonymous
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name );

            s_input = "450";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            s_input = "123456";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            s_input = "123456,45";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            s_input = "123e12";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            s_input = "123e40";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            s_input = "Johnny Johnson";
            input = GetValue(s_input);
            Console.WriteLine("\t" + input + " is a " + input.GetType().Name);

            //Wait for user
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static dynamic GetValue(string input)
        {
            //Set up CoR
            //- Handlers
            ToByte toByte = new ToByte();
            ToShort toShort = new ToShort();
            ToInt toInt = new ToInt();
            ToFloat toFloat = new ToFloat();
            ToDouble toDouble = new ToDouble();
            ToString toString = new ToString();

            //- Successors
            toByte.SetSuccessor(toShort);
            toShort.SetSuccessor(toInt);
            toInt.SetSuccessor(toFloat);
            toFloat.SetSuccessor(toDouble);
            toDouble.SetSuccessor(toString);

            //Call Cast from the first handler
            dynamic value = toByte.Cast(input);

            //Return value
            return value;

        } //GetType

    } //class Client
} //namespace
