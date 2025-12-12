using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace AllInOneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========Welcome to my All in one Program=========");
                Console.Clear();

                Console.WriteLine("1.File Management Exercise\n2.Jagged Arrays exercise\n3.2D Arrays exercise\n4.XML Files\n5.Exit Program");
                Console.Write("What would you like to do? ");
                bool isContinue = int.TryParse(Console.ReadLine(), out int input);

                while (isContinue == true)
                {
                    switch (input)
                    {
                        case 1:
                            FileManagement();
                            break;
                        case 2:
                            Jagged();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            isContinue = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.\n Do you want to try again ('Y/N'? ");
                            string sChoice = Console.ReadLine().ToUpper();
                            if (sChoice != "Y")
                            {
                                isContinue = false;
                            }
                            else isContinue = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Kak programming bruu!!");
            }
            Console.ReadKey();
        }
        static void FileManagement()
        {
            Console.WriteLine("\n N - Create file" +
                                "\n D - Delete file" +
                                "\n C - File Information" +
                                "\n I - Exit");
            Console.Write("What would you like to do? ");
            string Choice = Console.ReadLine().ToUpper();

            switch (Choice)
            {
                case "N":
                    Console.Write("File Path:  ");
                    string sPath = Console.ReadLine();

                    Console.Write("Name of the file: ");
                    string sFile = Console.ReadLine();
                    sPath += sFile;

                    FileStream outfile = new FileStream(sPath, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(outfile);

                    Console.WriteLine("Enter some text: ");
                    string sText = Console.ReadLine();
                    writer.WriteLine(sText);

                    writer.Dispose();
                    writer.Close();
                    outfile.Close();
                    break;
                case "D":
                    Console.Write("Enter file path: ");
                    string sFPath = Console.ReadLine();

                    FileStream outstream = new FileStream(sFPath, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(outstream);

                    Console.Write("Contents of the file: " + reader.ReadToEnd());

                    reader.Dispose();
                    reader.Close();
                    outstream.Close();
                    if (File.Exists(sFPath))
                    {
                        Console.Write("Are you sure you want to delete? ('Y/N')");
                        string sDelete = Console.ReadLine().ToUpper();
                        if (sDelete == "Y")
                        {
                            File.Delete(sFPath);
                            Console.WriteLine("File Deleted.");
                        }
                        else
                        {
                            Console.WriteLine("File not Deleted.");
                        }
                    }
                    break;
                case "C":
                    Console.Write("Enter file path: ");
                    string sPathFile = Console.ReadLine();

                    Console.Write("Enter file name (with the file extention): ");
                    string sFileName = Console.ReadLine();

                    FileStream streamer = new FileStream(sPathFile + sFileName, FileMode.Open, FileAccess.Read);
                    StreamReader readers = new StreamReader(streamer);
                    Console.WriteLine("Contents of the file: " /*+ readers.ReadToEnd()*/);
                    File.GetAttributes(readers.ToString());
                    File.GetCreationTime(readers.ToString());
                    File.GetLastAccessTime(readers.ToString());
                    readers.Dispose();
                    readers.Close();
                    streamer.Close();
                    break;
                case "I":
                    Console.WriteLine("Exiting...");

                    break;
                default:
                    Console.WriteLine("Invalid option.\n Do you want to try again ('Y/N'? ");
                    string sChoice = Console.ReadLine().ToUpper();

                    break;
            }

            Console.ReadKey();
        }
        static void Jagged()
        {
            string[][] Tree = new string[5][];
            
            Tree[0] = new string[5];
            Tree[0][0] = "    *";
            Tree[0][1] = "   ***  ";
            Tree[0][2] = "  *****  ";
            Tree[0][3] = " ******** ";
            Tree[0][4] = "*********** ";

            for (int i = 1; i < Tree.Length; i++)
            {
                Tree[i] = new string[0];  // Initialize them with empty arrays
            }

            for (int i = 0; i < Tree.Length; i++)
            {
                for (int j = 0; j < Tree[i].Length; j++)
                {
                    Console.WriteLine(Tree[i][j] + " ");
                }
                Console.WriteLine();
            } 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // Exit the program
            Environment.Exit(0);
        }
    }
}
