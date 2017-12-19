using System;
using System.Diagnostics;

namespace AboutMeQuiz
{
    class Program
    {
        public static bool Car()
        {
            Console.WriteLine("\nWhat brand was my first car? Pick a Number." +
                              "\n1) BMW" +
                              "\n2) Nissan" +
                              "\n3) Audi\n");
            var userInput = int.Parse(Console.ReadLine());
            return userInput == 2;
        }

        public static bool GameOn()
        {
            return true;
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

        static void Main(string[] args)
        {
            GameStart();
        }
    }
}
