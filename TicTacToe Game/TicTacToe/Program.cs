using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    class Program
    {
        static char[,] pos = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };//array of positions
        static int player = 1; //Player 1 is set to start game
        static int choice;
        static int iRow;
        static int iColumn;
        static int winflag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("XOXOXOXOXOXOXOXOXOXOXOX\n");
                Console.WriteLine("Welcome to Tic-Tac-Toe\n");
                Console.WriteLine("XOXOXOXOXOXOXOXOXOXOXOX\n\n");
                Console.WriteLine("Player1:X and Player2:O\n");
                if (player % 2 == 0) Console.WriteLine("Player 2's Turn\n");
                else Console.WriteLine("Player 1's Turn\n");

                ShowBoard();//Display the board with moves
                Console.Write("\nPosition you wish to place your mark (1 to 9): ");

                //2. Use CheckInput 
                bool isValidInput = false;
                do
                {
                    string input = Console.ReadLine();
                    isValidInput = CheckInput(input);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Sorry, that is not a valid option.");
                        Console.WriteLine("Press any key to try again.");
                    }
                } while (!isValidInput);

                // Determine whose turn it is
                char symbol = ' ';
                string sPlayerName = " ";
                //3.Switch Case
                switch (player % 2)
                {
                    case 0:
                        symbol = 'O';
                        sPlayerName = "Player 2";
                        break;
                    case 1:
                        symbol = 'X';
                        sPlayerName = "Player 1";
                        break;
                    default:
                        break;
                    
                }
                Console.WriteLine(sPlayerName + "'s Turn\n");

                //4. CheckWin();
                CheckWin(ref winflag);

                player++; // Increment player turns

            }
            while (winflag == 0);//5. Condition


            Console.Clear();//Clearing before Displaying results
            ShowBoard();
            player = player == 1 ? 2 : 1;

            //6. Display results
            if (winflag == 1)
            {
                string sWinnerName = "Player 1"; 
                Console.WriteLine(sWinnerName + " has won");
            }
            else if (winflag == 2)
            {
                string sWinnerName = "Player 2"; 
                Console.WriteLine(sWinnerName + " has won");
            }
            else if (winflag == -1)
            {
                Console.WriteLine("The game was a Draw");
            }
            Console.WriteLine("Thank you for playing. Press any key to exit.");
            Console.ReadKey();
        }
        //1. CheckInput
        //iRow = choice / 3;
        //iColumn = (choice-1) % 3;
        //if((choice % 3)==0)
        //{
        //    if (iRow > 0) iRow--;
        //    iColumn = 2;
        //}
        private static bool CheckInput(string input)
        {
            //validate the provided input and store it in the existing ‘choice’ variable if it is a number
            if (int.TryParse(input, out choice))
            {
                choice--;
                // convert and store the user input to the necessary row and column indices.
                iRow = choice / 3;
                iColumn = (choice - 1) % 3;
                if ((choice % 3) == 0)
                {
                    if (iRow > 0) iRow--;
                    iColumn = 2;
                }

                if(iRow >= 0 && iRow < 4)
                {
                    if (iColumn >= 0 && iColumn < 4)
                    {
                        return true;
                    }
                }
                // Check if the selected position is within the range
                if (choice < 0 || choice > 8)
                {
                    //Console.WriteLine("Position " + (choice + 1) + " is out of range (1 to 9). Please choose another position.");
                    return false;
                }
                // Check if the selected position has been played already
                if (pos[iRow, iColumn] == 'X' || pos[iRow, iColumn] == 'O')
                {
                    Console.WriteLine("Sorry, the position " + choice + " has already been palyed. Please choose another position.");
                    return false;
                }

                return true;
            }
          
            // If all checks pass, return true indicating that input the input is valid
            return true;
        }
        private static void CheckWin(ref int winflag)//4. Win Flag
        {
            //Winning Condition For Rows
            if ((pos[0, 0] == pos[0, 1] && pos[0, 1] == pos[0, 2]) || (pos[1, 0] == pos[1, 1] && pos[1, 1] == pos[1, 2]) || (pos[2, 0] == pos[2, 1] && pos[2, 1] == pos[2, 2]))
            {
                winflag = 1;
            }
            //Winning Condition For Columns
            else if ((pos[0, 0] == pos[1, 0] && pos[1, 0] == pos[2, 0]) || (pos[0, 1] == pos[1, 1] && pos[1, 1] == pos[2, 1]) || (pos[0, 2] == pos[1, 2] && pos[1, 2] == pos[2, 2]))
            {
                winflag = 1;
            }
            //Winning Condition For Diagonals
            else if ((pos[0, 0] == pos[1, 1] && pos[1, 1] == pos[2, 2]) || (pos[2, 0] == pos[1, 1] && pos[1, 1] == pos[0, 2]))
            {
                winflag = 1;
            }
            //Draw Condition
            else if (pos[0, 0] != '1' && pos[0, 1] != '2' && pos[0, 2] != '3' && pos[1, 0] != '4' && pos[1, 1] != '5' && pos[1, 2] != '6' && pos[2, 0] != '7' && pos[2, 1] != '8' && pos[2, 2] != '9')
            {
                winflag = -1;
            }
            else
            {
                winflag = 0;
            }
        }
        private static void ShowBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pos[0, 0], pos[0, 1], pos[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pos[1, 0], pos[1, 1], pos[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pos[2, 0], pos[2, 1], pos[2, 2]);
            Console.WriteLine("     |     |      ");
        }
    }
}
