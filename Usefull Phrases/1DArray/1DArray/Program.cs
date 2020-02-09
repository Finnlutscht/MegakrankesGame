using System;

namespace _1DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------1D-ARRAY-------------------------------------------------------------------------------------------------------------------------
            //n Array halt :)


            int[] ka 
                new int[2];

            ka[0] = 12;
            ka[1] = 3;
            Console.WriteLine(ka[0]);
            Console.ReadKey();

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
