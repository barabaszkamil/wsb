using System;

namespace _1_firs_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię:");//wyświetli Imię:
            Console.WriteLine("Kasia:");
            Console.WriteLine();


            /*Komentarz
             *w wielu
             *liniach
             */

            /*
             *
             *
             */

            Console.WriteLine("#");// pierwsza opcja napisania w wielu wierszach
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");


            Console.WriteLine("\n#\n##\n###\n####");//druga opcja napisania w wielu wierszach

            string name;
            name = "Janusz";

            // +konkatenacja
            Console.WriteLine("\nMasz na imię: " + name);

            Console.WriteLine("masz na imię: {0}", name);

            int age = 20;

            sbyte age1 = 20;

            /* użytkownik podaje z klawiatury długośc boku
             * oblicz pole kwadratu
             */


            /*
             * Oblicz pole trójkąta
             * dane podaje użytkownik z klawiatury
             */





            Console.ReadKey();

        }
    }
}
