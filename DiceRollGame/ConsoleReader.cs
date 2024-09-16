using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal static class ConsoleReader
    {
        public static int HandleUserInput(int _number )
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Enter a number");
                success = int.TryParse(Console.ReadLine(), out _number);
                if (success)
                {
                    return _number;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    
                }
                
            }
            return 0;
        }
    }
}
