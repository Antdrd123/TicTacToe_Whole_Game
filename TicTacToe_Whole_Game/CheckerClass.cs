using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class CheckerClass
    {
        public static bool Checker(string[,] board)
        {

            if (CheckHorizontalRows(board) == false)
            {
                if (CheckVerticalRows(board) == false)
                {
                    if (CheckDiagonalRows(board) == false)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public static bool CheckHorizontalRows(string[,] board)
        {
            int bint = 0;
            int mint = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == "O")
                    {
                        bint++;
                        if (bint == 3)
                        {
                            Console.WriteLine("Player O wins!!");
                            return true;
                        }
                    }
                    else if (board[i, j] == "X")
                    {
                        mint++;
                        if (mint == 3)
                        {
                            Console.WriteLine("Player X wins!!");
                            return true;
                        }
                    }
                }
                bint = 0;
                mint = 0;
            }
            return false;
        }
        public static bool CheckVerticalRows(string[,] board)
        {
            int bint = 0;
            int mint = 0;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[j, i] == "O")
                    {
                        bint++;
                        if (bint == 3)
                        {
                            Console.WriteLine("Player O wins!!");
                            return true;
                        }
                    }
                    else if (board[j, i] == "X")
                    {
                        mint++;
                        if (mint == 3)
                        {
                            Console.WriteLine("Player X wins!!");
                            return true;
                        }
                    }
                }
                bint = 0;
                mint = 0;
            }
            return false;
        }
        public static bool CheckDiagonalRows(string[,] board)
        {
            int mint = 0;
            int bint = 0;
            bool mool = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, i] == "O")
                {
                    bint++;
                    if (bint == 3)
                    {
                        Console.WriteLine("Player O wins!!");
                        mool = true;
                        return true;
                    }
                }
                else if (board[i, i] == "X")
                {
                    mint++;
                    if (mint == 3)
                    {
                        Console.WriteLine("Player X wins!!");
                        mool = true;
                        return true;
                    }
                }
            }
            bint = 0;
            mint = 0;
            if (mool == false)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = board.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (i + j == board.GetLength(1) - 1)
                        {
                            if (board[i, j] == "O")
                            {
                                bint++;
                                if (bint == 3)
                                {
                                    Console.WriteLine("Player O wins!!");
                                    mool = true;
                                    return true;
                                }
                            }
                            else if (board[i, j] == "X")
                            {
                                mint++;
                                if (mint == 3)
                                {
                                    Console.WriteLine("Player X wins!!");
                                    mool = true;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
