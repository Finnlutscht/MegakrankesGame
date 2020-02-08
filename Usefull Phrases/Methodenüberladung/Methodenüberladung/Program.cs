using System;

namespace Methodenüberladung
{
    //------------------------------Methodenüberladung-----------------------------------------------------
    //Eine Methode in mehrer Ausführung definiert (unterschiedliche Parameterlisten als unterscheidung)
    class Program
    {
        static void Main(string[] args)
        {
            PersonenBeschreibung("Mäxchen");
            PersonenBeschreibung("Mäxchen", 17);
            Console.ReadKey();
        }

        static void PersonenBeschreibung(string name)
        {
            Console.WriteLine("Die Person heißt " + name);
        }

        static void PersonenBeschreibung(string name, int alter)
        {
            Console.WriteLine("Die Person heißt " + name + "und ist " + alter + " Jahre alt!");
        }
    }
}
