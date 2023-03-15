using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board1 ={
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }

            };
            PrintBoard board = new PrintBoard();
            board.Board = board1;
            
            int counter = 1;
            
            PlayerInput.Introduce();
            Console.WriteLine();

            while(counter <= 9)
            {
                if(counter %2 != 0)
                {
                    Console.WriteLine("Player 1, select field numbered from 1 to 9.");
                }
                else
                {
                    Console.WriteLine("Player 2, select field numbered from 1 to 9.");

                }
                PrintBoard.PrintsBoard(board1);
                
                ChoiceCheck.Choice(PlayerInput.UserPreference(PlayerInput.InputField()), board1, counter);
                counter++;

                if (CheckerClass.Checker(board1) == true)
                {
                    counter = 11;
                }
                else if (CheckerClass.Checker(board1) == false && counter == 10)
                {
                    Console.WriteLine("It is a draw!");
                }
            }
            PrintBoard.PrintsBoard(board1);
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
