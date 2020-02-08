using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aufruf der Methode "neueMethode"
            neueMethode(16, "Julius");

            //Aufruf der Methode "Addition"
            int ausgabeZahl = Addition(10, 5);
            Console.WriteLine(ausgabeZahl);
            Console.ReadKey();
            //So würde es auch gehen: Console.WriteLine(Adition(10, 5));
        }
        static void neueMethode(int alter, string name)
        {
            Console.WriteLine("Mein Alter ist " + alter + " und ich heiße " + name);
            Console.ReadKey();

        }

        static int Addition(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }
    }
    
}
