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
            board.Board = board1; // zašto se ne može direktno inicijalizirati??
            
            // Kako napraviti da se ne inicijalizira svaki put vrijednost ploče, a da ona nije u program.csu( Možda sa private prop srediti aplikaciju?)
            int counter = 1;
            //PrintBoard.PrintsBoard(board1);
            PlayerInput.Introduce();
            Console.WriteLine();

            while(counter <= 9)
            {
                PrintBoard.PrintsBoard(board1);
                //ChoiceCheck.CheckIfFilled(PlayerInput.UserPreference(PlayerInput.InputField()), PrintBoard.Board());
                ChoiceCheck.Choice(PlayerInput.UserPreference(PlayerInput.InputField()), board1, counter);
                counter++;

                if (CheckerClass.Checker(board1) == false && counter == 10)
                {
                    Console.WriteLine("It is a draw!");
                }
                else if(CheckerClass.Checker(board1) == true)
                {
                    counter = 11;
                }
            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
