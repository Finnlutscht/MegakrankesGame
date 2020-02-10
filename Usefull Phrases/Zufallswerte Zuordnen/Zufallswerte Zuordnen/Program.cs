using System;


namespace Zufall

{

    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] runTime = new int[30];


            for (int i = 0; i < 30; i++)
            {

                int zufallszahl = rnd.Next(10, 20);

                runTime[i] = zufallszahl;

                Console.WriteLine(runTime[i]);

            }

            Console.ReadKey();
        }
    }




}
