using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class ChoiceCheck
    {
        public static void Choice(int z, string[,] board, int counter)
        {
            if(CheckIfFilled(z, board) == true)
            {
                switch(z)
                {
                    case 1: board[0, 0] = XorO(counter); break;
                    case 2: board[0, 1] = XorO(counter); break;
                    case 3: board[0, 2] = XorO(counter); break;
                    case 4: board[1, 0] = XorO(counter); break;
                    case 5: board[1, 1] = XorO(counter); break;
                    case 6: board[1, 2] = XorO(counter); break;
                    case 7: board[2, 0] = XorO(counter); break;
                    case 8: board[2, 1] = XorO(counter); break;
                    case 9: board[2, 2] = XorO(counter); break;
                }
            }
        }
        public static string XorO (int counter)
        {
            if(counter % 2 != 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        public static bool CheckIfFilled(int w, string[,] tic)
        {


            if (w == 1 && tic[0, 0] == "1") { return true; }
            else if (w == 2 && tic[0, 1] == "2") { return true; }
            else if (w == 3 && tic[0, 2] == "3") { return true; }
            else if (w == 4 && tic[1, 0] == "4") { return true; }
            else if (w == 5 && tic[1, 1] == "5") { return true; }
            else if (w == 6 && tic[1, 2] == "6") { return true; }
            else if (w == 7 && tic[2, 0] == "7") { return true; }
            else if (w == 8 && tic[2, 1] == "8") { return true; }
            else if (w == 9 && tic[2, 2] == "9") { return true; }
            else
            {
                Console.WriteLine("This field is already taken!");
                return false;
            }

        }
    }
}
