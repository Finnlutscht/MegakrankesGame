using System;

namespace _1DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------1D-ARRAY-------------------------------------------------------------------------------------------------------------------------
            //n Array halt :)

            string[] namenListe = new string[3];

            namenListe[0] = "Finn";
            namenListe[1] = "Max";
            namenListe[2] = "Julius";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(namenListe[i]);

            }
            Console.ReadKey();
        }
    }
}
