using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------2D-ARRAYS------------------------------------------------------------------------------------------------------
            //n Array halt mit 2. Wert quasi ne Tabelle

            string[,] produktListe = new string[3, 2];

            produktListe[0, 0] = "Senf";
            produktListe[0, 1] = "1 Euro ";

            produktListe[1, 0] = "Nutella";
            produktListe[1, 1] = "2 Euro";

            produktListe[2, 0] = "Tapas";
            produktListe[2, 1] = "3Euro";


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(produktListe[i, 0]);
                Console.WriteLine(produktListe[i, 1]);

            }
            Console.ReadKey();
        }
    }
}

