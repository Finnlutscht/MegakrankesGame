using System;

namespace ForEach_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------FOREACH-SCHLEIFE-----------------------------------------------------------------------------------------------------------------
            //foreach = alles / gibt einmal alles aus

            string[] namensListe = new string[3];

            namensListe[0] = "Max";
            namensListe[1] = "Finn";
            namensListe[2] = "Julius";

            foreach (string name in namensListe)
            {
                Console.WriteLine(name);

            }
            Console.ReadKey();
        }
    }
}
