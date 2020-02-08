using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------SWITCH-------------------------------------------------------------------------
            //Prüft ob "das hier" exakt die Variable ist
            //Anwendung : Zufälliges Matchmaking
            string zahls = "Hallo";
            switch (zahls)
            {

                case "halo":
                    Console.WriteLine("zahl hat den Wert 1");
                    break;

                case "hallo":
                    Console.WriteLine("zahl hat den Wert 2");

                    break;

                default:
                    Console.WriteLine("die zahl hat einen anderen Wert");

                    break;
            }
            Console.WriteLine("Das war switch!(Z.16)");
            Console.ReadKey();

        }
    }
}
