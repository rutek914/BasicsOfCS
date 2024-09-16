using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal static class Dice
    {
        public static int _rolledDot;
        private static readonly Random _random;

        static Dice()
        {
            _random = new Random();
        }

        public static int RollDice()
        {
            _rolledDot = _random.Next(1, 7);
            return _rolledDot;
        }
    }
}
