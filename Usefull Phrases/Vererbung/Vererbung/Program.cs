using System;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------Vererbung---------------------------------------------------------------------------------------
            //Erweitern von Klassen ohne diese direkt zu verändern
            //Man erstellt eine neue Klasse, welche die Eigenschaften und Methoden der geerbten Klasse übernimmt


            //Neue Schildröte wird erzeugt
            Schildkröte schildi = new Schildkröte();


            //Ich kann auf Zeug für die Klasse Schildkröte zugreifen
            schildi.Name = "Drecksvieh";
            Console.WriteLine(schildi.Name);
            Console.ReadKey();
            Console.Beep();

            //Ich kann auf Zeug für die Klasse Tier zugreifen
            schildi.Kacken();
            Console.ReadKey();
            Console.Beep();

            schildi.Nichtskönnen();
            Console.ReadKey();
            Console.Beep();

            schildi.SterbenwennesaufdemRückenliegt();
            Console.ReadKey();
            Console.Beep();

            schildi.Langweilig = true;
            if (schildi.Langweilig == true)
                Console.WriteLine("Schilkröten sind einfach Langweilig!");
            Console.ReadKey();
            Console.Beep();

            //Ich kann auf Zeug für die Klasse Tier zugreifen
            schildi.Geschlecht = "Scheiße";
            Console.WriteLine(schildi.Geschlecht);
            Console.ReadKey();
            Console.Beep();

        }
    }


  class Tier
    {
        //Zeug für Klasse Tier
        public string Geschlecht { get; set; }

        public void Kacken()
        {
            Console.WriteLine("Jedes Tier kann kacken");
        }
    }
    class Schildkröte : Tier
    {
        //Zeug für Klasse Schildkröte
        public bool Langweilig;
        public string Name;

            public void Nichtskönnen()
        {
            Console.WriteLine("Eine scheiss Schildkröte kann absolut garnichts!");
        }

        public void SterbenwennesaufdemRückenliegt()
        {
            Console.WriteLine("Achja, außer Sterben wenn es auf dem Rücken liegt, ja moiiin");
        }

    }
}
