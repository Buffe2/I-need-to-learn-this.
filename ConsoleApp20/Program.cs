using System;
namespace Uppgift_3._11
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en kategori.");
            Console.WriteLine("1. Musik");
            Console.WriteLine("2. Historia");
            Console.WriteLine("3. Geografi");

            string val = Console.ReadLine();
            string svar = "";

            switch (val)
            {
                case "1":
                    Console.WriteLine("Vilka skapade låten Mamma Mia?");
                    svar = "abba";
                    break;

                case "2":
                    Console.WriteLine("När slutade WWII?");
                    svar = "1945";
                    break;

                case "3":
                    Console.WriteLine("I vilket land ligger Amsterdam?");
                    svar = "nederländerna";
                    break;

                default:
                    break;
            }
            string rättsvar = Console.ReadLine().ToLower();
            if (rättsvar == svar)
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Du svarade fel!");
            }
        }
    }
}