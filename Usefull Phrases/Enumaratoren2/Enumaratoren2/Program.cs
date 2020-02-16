using System;

namespace Enumaratoren
{
    class Program

    {
        static void Main(string[] args)
        {




            Wochentage tag1 = Wochentage.Montag;
            for (int i = 0; i < 4; i++)
            {

                switch (tag1)
                {
                    case Wochentage.Montag:
                        Console.WriteLine("Montag");
                        break;

                    case Wochentage.Dienstag:
                        Console.WriteLine("Dienstag");
                        break;
                    case Wochentage.Mittwoch:
                        Console.WriteLine("Mittwoch");
                        break;


                }
                tag1++;
            }


            Console.ReadKey();
        }
    }

    //Wochentage als eigener Datentyp
    //Alles bisle Leserlicher
    enum Wochentage
    {
        Montag,
        Dienstag = 2,
        Mittwoch = 3,
        Donnerstag = 4,
        Freitag = 5,
        Samstag = 6,
        Sonntag = 7

    }
}
