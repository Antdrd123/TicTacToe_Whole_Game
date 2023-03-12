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
                    case 1:
                        if(counter %2 != 0)
                        {
                            
                            board[0, 0] = "X";
                            //return board[0, 0];
                        }
                        else
                        {
                            board[0, 0] = "O";
                            //return board[0, 0];
                        }
                        break;
                    case 2:
                        if(counter %2 != 0)
                        {
                            board[0, 1] = "X";
                        }
                        else
                        {
                            board[0, 1] = "O";
                        }
                        break;
                    case 3:
                        if (counter % 2 != 0)
                        {
                            board[0, 2] = "X";
                        }
                        else
                        {
                            board[0, 2] = "O";
                        }
                        break;
                    case 4:
                        if (counter % 2 != 0)
                        {
                            board[1, 0] = "X";
                        }
                        else
                        {
                            board[1, 0] = "O";
                        }
                        break;
                    case 5:
                        if (counter % 2 != 0)
                        {
                            board[1, 1] = "X";
                        }
                        else
                        {
                            board[1, 1] = "O";
                        }
                        break;
                    case 6:
                        if (counter % 2 != 0)
                        {
                            board[1, 2] = "X";
                        }
                        else
                        {
                            board[1, 2] = "O";
                        }
                        break;
                    case 7:
                        if (counter % 2 != 0)
                        {
                            board[2, 0] = "X";
                        }
                        else
                        {
                            board[2, 0] = "O";
                        }
                        break;
                    case 8:
                        if (counter % 2 != 0)
                        {
                            board[2, 1] = "X";
                        }
                        else
                        {
                            board[2, 1] = "O";
                        }
                        break;
                    case 9:
                        if (counter % 2 != 0)
                        {
                            board[2, 2] = "X";
                        }
                        else
                        {
                            board[2, 2] = "O";
                        }
                        break;
                }
            }
        }

        public static bool CheckIfFilled(int w, string[,] tic)
        {
            switch(w)
            {
                case 1:
                    if(int.TryParse(tic[0, 0], out int smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 2:
                    if (int.TryParse(tic[0, 1], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 3:
                    if (int.TryParse(tic[0, 2], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 4:
                    if (int.TryParse(tic[1, 0], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 5:
                    if (int.TryParse(tic[1, 1], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 6:
                    if (int.TryParse(tic[1, 2], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                   
                case 7:
                    if (int.TryParse(tic[2, 0], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }

                case 8:
                    if (int.TryParse(tic[2, 1], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
                    
                case 9:
                    if (int.TryParse(tic[2,2], out smint))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This field is taken. Try again!");
                        return false;
                    }
            }
            return false;
        }
    }
}
