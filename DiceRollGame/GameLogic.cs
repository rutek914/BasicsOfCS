using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal static class GameLogic
    {
        private const int _initialTries = 5;
        private static int _number;
        private static int _chances = _initialTries;
        public static void BeginOfTheGame()
        {
            Dice.RollDice();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {_initialTries} tries.");
        }
        public static void GuessLoop()
        {
            while (_chances > 0)
            {
                _number = ConsoleReader.HandleUserInput(_number);
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
        public static void Play()
        {
            BeginOfTheGame();
            GuessLoop();
        }
    }
}
