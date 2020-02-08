using System;

namespace IfAnweisungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------IF-ANWEISUNG-------------------------------------------------------------------------------------------
            //sollte man Können :=)
            Boolean fair = true;

            if (fair == true)
            {
                Console.WriteLine("Das Spiel ist fair");

            }
            else
            {
                Console.WriteLine("Das Spiel ist unfair!");
            }
            Console.ReadKey();
        }
    }
}
