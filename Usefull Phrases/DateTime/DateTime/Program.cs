using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zeitpunkte
{//Zeitpunkte koennen gespeichert werden
    //Zeitmessung in Ticks 1 Tick = 100 Nanosekunden
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime zeitpunkt = DateTime.Now;
            //  Console.WriteLine(zeitpunkt);
            // Console.ReadKey();
            // Console.Beep();

            //Console.WriteLine("Tag: " + zeitpunkt.Day);
            // Console.ReadKey();
            //Console.Beep();

            // Console.WriteLine("Monat: " + zeitpunkt.Month);
            //Console.ReadKey();
            //Console.Beep();

            //Console.WriteLine("Jahr: " + zeitpunkt.Year);
            //Console.Beep();
            //Console.ReadKey();


            DateTime zeitpunkt = DateTime.Now;
            Console.WriteLine(zeitpunkt);
            Console.WriteLine(zeitpunkt.AddYears(10));
            Console.ReadKey();
            Console.Beep();

            Console.WriteLine(zeitpunkt.AddYears(-10));
            Console.ReadKey();
            Console.Beep();

            //Daten
            Console.WriteLine(zeitpunkt.ToShortDateString());
            Console.ReadKey();
            Console.Beep();

            Console.WriteLine(zeitpunkt.ToLongDateString());
            Console.ReadKey();
            Console.Beep();

            //Uhrzeiten
            Console.WriteLine(zeitpunkt.ToLongTimeString());
            Console.ReadKey();
            Console.Beep();

            Console.WriteLine(zeitpunkt.ToShortTimeString());
            Console.ReadKey();
            Console.Beep();

        }
    }
}
