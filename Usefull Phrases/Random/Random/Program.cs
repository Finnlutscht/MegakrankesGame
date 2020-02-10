using System;
using System.Collections.Generic;
using System.Linq;

namespace Zufallszeugs
{

    class Laufer
    {

        public double runTime { get; set; }
        public string name { get; set; }
        public Laufer(double prt, string pname)
        {
        runTime = prt;
            name = pname;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            string erster = "Julius";
            int besteZeit = 0;
            int drawTime = 0;

            Random rnd = new Random();
            int[] runTime = new int[4];

            for (int i = 1; i < 4; i++)
            {

                int zufallszahl = rnd.Next(10, 20);

                runTime[i] = zufallszahl;

                Console.WriteLine(runTime[i]);

                if ( i == 1)
                {
                    Laufer JuJu = new Laufer(runTime[i], "Julius");
                }
                else if (i == 2)  
                {
                    Laufer Max = new Laufer(runTime[i], "Max");
                }
                else if(i == 3)
                {
                  Laufer Finn = new Laufer(runTime[i], "Finn");
                }
            }
            
            Console.ReadKey();



            if (runTime[1] == runTime[2] && runTime[1] > runTime[3])
            {
                drawTime = runTime[1];
                Console.WriteLine("Julius und Max waren gleich schnell mit einer Zeit von " + drawTime + " und belegen zusammen den zweiten Platz");
                    erster = "Finn";
            }
            else if (runTime[1] == runTime[2] && runTime[1] < runTime[3])
            {
                drawTime = runTime[1];
                
                erster = "Julius und Max";
            }


            if (runTime[1] == runTime[3] && runTime[1] > runTime[2])
            {
                drawTime = runTime[1]; 
                Console.WriteLine("Julius und Finn waren gleich schnell mit einer Zeit von " + drawTime + " und belegen zusammen den zweiten Platz");
                erster = "Max";
            }
            else if (runTime[1] == runTime[3] && runTime[1] < runTime[2])
            {
                drawTime = runTime[1];

                erster = "Julius und Finn";
            }



            if (runTime[2] == runTime[3] && runTime[3] > runTime[1])
            {
                drawTime = runTime[2];
                Console.WriteLine("Julius und Max waren gleich schnell mit einer Zeit von " + drawTime + " und belegen zusammen den zweiten Platz");
                erster = "Julius";
            }
            else if (runTime[1] == runTime[2] && runTime[3] < runTime[1])
            {
                drawTime = runTime[2];

                erster = "Finn und Max";
            }



            if (runTime[2] > runTime[1] && runTime[3] > runTime[1])
            {
                erster = "Julius";
                besteZeit = runTime[1];
            }
            else if (runTime[1] > runTime[3] && runTime[2] > runTime[3])
            {
                erster = "Finn";
                besteZeit = runTime[3];
            }
            else if (runTime[1] > runTime[2] && runTime[3] > runTime[2])
            {
                erster = "Max";
                besteZeit = runTime[2];
            }


            Console.WriteLine("Der schnellste Läufer  ist " + erster + " mit einer Zeit von " + besteZeit);






















            /*


             string[,] RunnerList = new string[3, 2];

             RunnerList[0, 0] = JuJu.name;
             RunnerList[0, 1] = JuJu.randomTime + " s";

             RunnerList[1, 0] = Max.name;
             RunnerList[1, 1] = Max.randomTime + " s";

             RunnerList[2, 0] = Finn.name;
             RunnerList[2, 1] = Max.randomTime + " s";


             for (int i = 0; i < 3; i++)
             {
             Console.WriteLine("Name: " + RunnerList[i, 0]);
             Console.WriteLine("Zeit: " + RunnerList[i, 1]);
             }

             Console.ReadKey();

             Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
             Console.ReadKey();


             for (int i = 0; i < 3; i++)
             {
                 for (int u = 0; u < 2; u++)
                 {

                 }
             }

             Random rnd = new Random();
             int[] runTime = new int[30];


             for (int i = 0; i < 30; i++)
             {

                 int zufallszahl = rnd.Next(10, 20);

                 runTime[i] = zufallszahl;

                 Console.WriteLine(runTime[i]);

             }




             */














            /*    for (int i = 0; i < 5; i++)
                {

                Random random = new Random();

                int zufallszahl = random.Next(10, 20);

                Console.WriteLine(zufallszahl);

                }
                Console.ReadKey();   */











        }




    }

    
}
