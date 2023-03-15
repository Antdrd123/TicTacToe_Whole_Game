using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class PrintBoard
    {

        public string[,] Board { get; set; }
        public static string[,] PrintsBoard(string[,] board)
        {
            
            

            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[0,0]}  |  {board[0,1]}  |  {board[0,2]}   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[1,0]}  |  {board[1,1]}  |  {board[1,2]}   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[2,0]}  |  {board[2, 1]}  |  {board[2, 2]}    ");
            Console.WriteLine("     |     |      ");

            return board;
        }
    }
}
