using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal static class GameLogic
    {
        private static int _number;
        private static int _chances = 3;
        private static void HandleUserInput()
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Enter a number");
                success = int.TryParse(Console.ReadLine(), out _number);
                if (success)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }

        }
        public static void BeginOfTheGame()
        {
            Dice.RollDice();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        }

        public static void GuessLoop()
        {
            while (_chances > 0)
            {

                HandleUserInput();
                if (_number == Dice._rolledDot)
                {
                    Console.WriteLine("You Win");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Number");
                    _chances--;
                }
            }
            Console.WriteLine("You lose");


        }
    }
}
