using System;
using System.Collections.Generic;

namespace Testitest
{
    class Program
    {
        static void Main(string[] args)
        {


            //Aktuelle und neue Uhrzeit
            // DateTime aktuell = DateTime.Now;
            //  DateTime spaeter = aktuell.AddDays(2);

            //Berechne den Unterschied
            // long zeitDiffTicks = spaeter.Ticks - aktuell.Ticks;
            //  long zeitDiffStunden = zeitDiffTicks / TimeSpan.TicksPerHour;


            //Gebe die Zeitdifferenz aus
            // Console.WriteLine(zeitDiffStunden);
            //  Console.ReadKey();

            /*
            TimeSpan zeitspanne = new TimeSpan(-10, 0, 0);

            Console.WriteLine(zeitspanne);
            Console.ReadKey();
            Console.Beep();


            Console.WriteLine(zeitspanne.Duration());
            Console.ReadKey();
            Console.Beep();



            TimeSpan zeitspanne2 = new TimeSpan(20, 0, 0);

            Console.WriteLine(zeitspanne2);
            Console.ReadKey();
            Console.Beep();

            Console.WriteLine(zeitspanne2.Negate());
            Console.ReadKey();
            Console.Beep();
            */


            Laufer JuJu = new Laufer(19.24);
            Laufer Maexchen = new Laufer(21.58);
            Laufer Finn = new Laufer(17.91);

            List<double> Zeitenliste = new List<double>();

            Zeitenliste.Add(JuJu.LaufZeit);
            Zeitenliste.Add(Maexchen.LaufZeit);
            Zeitenliste.Add(Finn.LaufZeit);



            foreach (double LaufZeit in Zeitenliste)
            {
                Console.WriteLine(LaufZeit);
            }


        }
    }
    



}
