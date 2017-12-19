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

        public static int[] YearAndMonthMovedToUsa()
        {
            Console.WriteLine("\nWhat year did I move to the USA, 2015 or 2016?");
            int[] monthAndYear = new int[2];
            try
            {
                var year = int.Parse(Console.ReadLine());
                monthAndYear[0] = year;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Exception Message: {e.Message}");
                Console.WriteLine("My custom catch message: Error entering the year.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine(@"//The finally block works :)");
            }

            Console.WriteLine("\nWhat month of that year was it? pick 1-12");
            var month = int.Parse(Console.ReadLine());
            monthAndYear[1] = month;

            return monthAndYear;
        }


        public static string FavoriteCartoon()
        {
            Console.WriteLine("\nWhat is on of my favorite Cartoons?" +
                              "\n1) Micky Mouse" +
                              "\n2) Tom and Jerry" +
                              "\n3) Toy Story");

            var cartoon = int.Parse(Console.ReadLine());
            return cartoon == 2 ? "Tom and Jerry" : "Meh";
        }


        public static int FavoriteNumber()
        {
            Console.WriteLine("\nWhat's my favorite number?");
            var fav = Console.ReadLine();
            if (int.Parse(fav) == 1) return 1;
            return -1;
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
