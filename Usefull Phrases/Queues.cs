using System;
using System.Collections.Generic;

namespace QueuesSchlangen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisiere Schlange
            Queue<string> warteschlange = new Queue<string>();

            //Werte an Warteschlange hinyufuegen
            warteschlange.Enqueue("Finn");
            warteschlange.Enqueue("Maexchen");
            warteschlange.Enqueue("JuJu");

            //Lese Werte  und Loeschen
            Console.WriteLine(warteschlange.Dequeue());
            Console.WriteLine(warteschlange.Dequeue());
            //Lese Werte ohne zu loeschen
            Console.WriteLine(warteschlange.Peek());
            Console.WriteLine(warteschlange.Peek());

            Console.ReadKey();

        }
    }
}
