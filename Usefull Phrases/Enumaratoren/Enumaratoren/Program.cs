using System;

namespace Enumaratoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Wochentage tag = Wochentage.Montag;

            switch (tag)
            {
                case Wochentage.Montag:
                    Console.WriteLine("Montag");
                    break;

                case Wochentage.Dienstag:
                    Console.WriteLine("Dienstag");
                    break;

                    
            }
            Console.ReadKey();
        }
    }

    //Wochentage als eigener Datentyp
    //Alles bisle Leserlicher
    enum Wochentage
    {
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 3,
        Donnerstag = 4,
        Freitag = 5,
        Samstag = 6,
        Sonntag = 7

    }
}
