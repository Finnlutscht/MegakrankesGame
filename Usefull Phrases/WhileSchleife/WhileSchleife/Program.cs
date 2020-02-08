using System;

namespace WhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------WHILE-SCHLEIFE---------------------------------------------------------------------------------------------------
            //Wiederholt Anweisung so und so oft mit Bedingung
            //-------------DO -WHILE-SCHLEIFE------------------------------------------------------------------------------------------------
            //Das gleiche nur das mit do bla bla bla erst einmal ausgegeben wird bevor while schleife kommt
            int zahlw = 1;
            while (zahlw <= 5)
            {

                Console.WriteLine(zahlw);
                zahlw += 1;
            }


            int zahld = 0;
            do
            {
                Console.WriteLine(zahld);
                zahld += 1;
            }


            while (zahld <= 5);
            Console.ReadKey();
        }
    }
}
