using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisiere Stack
            Stack<string> karten = new Stack<string>();

            //Füge Wert hinzu wie Kartenstapel liegt die erste ganz oben, weil sie zuletzt draufgelegt wird
            karten.Push("Herz 2");
            karten.Push("Karo 3");
            karten.Push("Pik 4");

            //Lese Werte und löscht letzten
            Console.WriteLine(karten.Pop());
            Console.WriteLine(karten.Pop());
            Console.WriteLine(karten.Pop());

            //Lese Wert ohne löschen
            Console.WriteLine(karten.Peek());
            Console.ReadKey();
        
        }
    }
}
