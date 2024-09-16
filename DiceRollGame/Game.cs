namespace DiceRollGame
{
    internal class Game
    {
        static void Main(string[] args)
        {
            GameLogic.BeginOfTheGame();
            GameLogic.GuessLoop();
            Console.ReadKey();
        }
    }
}
