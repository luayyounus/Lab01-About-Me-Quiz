using System;
using System.Diagnostics;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart();
        }

        public static void GameStart()
        {
            Console.WriteLine("Welcome to the about me Quiz!");
            var gameOn = true;
            while (gameOn)
            {
                gameOn = GameOn();
            }
            Console.WriteLine("Thanks for playing my quiz!");
            Console.Read();
        }

        public static bool GameOn()
        {
            return true;
        }
    }
}
