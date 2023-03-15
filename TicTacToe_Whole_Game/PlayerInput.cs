using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class PlayerInput
    {
        public static void Introduce()
        {
            Console.WriteLine("Hi, you are going to play TicTacToe today. Let's see who is going to win - X or O!");
        }
        public static int InputField()
        {
            while(true)
            {
                
                Console.WriteLine("INPUT: ");
                string input = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(input, out int inputNum))
                {
                    return inputNum;
                }
                else
                {
                    Console.WriteLine("Wrong input! Not a number!");
                }
            }
        }
        public static int UserPreference(int x)
        {
            while(true)
            {
                if (x > 0 && x <= 9)
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Try again!");
                    x = InputField();
                }
            }
        }
    }
}
