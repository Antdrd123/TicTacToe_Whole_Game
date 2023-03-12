using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Whole_Game
{
    internal class PlayerInput
    {
        // provjera tko je na redu(x ili o)- brojač ( brojač MORA biti u program.cs jer se u metodi stalno vraća na 0)
        // provjera je li netko pobjedio
        // ponoviti proces nakon što je ispunjeno 1 polje
        // završiti proces ako su sva polja popunjena
        
        public static void Introduce()
        {
            Console.WriteLine("Hi, you are going to play TicTacToe today. Let's see who is going to win - X or O!");
        }
        public static int InputField()
        {
            while(true)
            {
                
                Console.WriteLine("Select field numbered from 1 to 9.");
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
