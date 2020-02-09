using System;
using System.Collections.Generic;

namespace Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namensListe = new List<string>();

            namensListe.Add("JuJu");
            namensListe.Add("Finn");
            namensListe.Add("Mäxchen");
            namensListe.Add("Junk");


            foreach(string name in namensListe)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();


            namensListe.Remove("Junk");
            foreach (string name in namensListe)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
