﻿

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)

        {

            ValueTypes();

            for (;;)
            {
                Greeting();
                Age();
                Settings();
                
            }


        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }


        /// <summary>
        /// Zapytanie o wiek
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("Podaj swoj wiek....");
            int age;

            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Jestes pelnoletni wiec mozesz wypic Browara");

            }
            else
            {
                Console.WriteLine("Czesc, mozemy Ci zaoferowac mleko");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie uzytkownika
        /// </summary>

        private static void Greeting()
        {
            Console.WriteLine("Wprowadz swoje imie :");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj" + name);
        }
    }
}
