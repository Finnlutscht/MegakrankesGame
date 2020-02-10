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
            bool maxNameVergeben = false;
            int zufallszahl;
            int zufallszahl2;
            string randomName = "0";
            int lZeit = 0;
            

            string[] generatedNames = new string[50];
            List<string> lauferListe = new List<string>();

            /*Zufallsnamen();
            generatedNames[0] = randomName;
            lauferListe.Add(lZeit + randomName);

    */
           

            for (int i = 0; i < 5; i++)
            {
                     Zufallsnamen();
                     proof();   
                generatedNames[i] = randomName;
            }


             void proof()
             {
                
                
                if (generatedNames[0] == randomName)
                {                        
                    Zufallsnamen();
                    proof();  
                   

                }
                else if (generatedNames[1] == randomName)
                {
                    Zufallsnamen();
                    proof();
                }

                else if (generatedNames[2] == randomName)
                {
                    // generatedNames[i] = randomName;
                    Zufallsnamen();
                    proof();
                }

                else if (generatedNames[3] == randomName)
                {
                    Zufallsnamen();
                    proof();
                }  
                
                else if (generatedNames[4] == randomName)
                {
                    Zufallsnamen();
                    proof();
                }

                else
                {
                lauferListe.Add(randomName + " mit einer Zeit von " + lZeit);
                  
                }
                
        }


            Console.WriteLine("-----------------------------Lauferergebnisse------------------------------");

            foreach (string ZeitRandomname in lauferListe)
            {
            Console.WriteLine(ZeitRandomname);

            }
            Console.WriteLine("----------------------------Platzierungen-------------------------------");

            lauferListe.Sort();

            foreach (string value in lauferListe)
            {
               
                Console.WriteLine(value);

            }


            void Zufallsnamen()
            {

                Random rnd = new Random();
                int[] runTime = new int[4];

                string[] zufallsnamen = new string[8];

                zufallsnamen[0] = "Max";
                zufallsnamen[1] = "Julius";
                zufallsnamen[2] = "Finn";
                zufallsnamen[3] = "Victoria";
                zufallsnamen[4] = "Angela Merkel";
                zufallsnamen[5] = "Kobe Bryant";
                zufallsnamen[6] = "die hässliche Schildkröte";
                zufallsnamen[7] = "Flo";

                int[] gleicheZahlen = new int[5];

                for (int i = 1; i < 2; i++)
                {
                    zufallszahl = rnd.Next(10, 20);
                    zufallszahl2 = rnd.Next(0, 8);

                    runTime[i] = zufallszahl;

                    Laufer l = new Laufer(runTime[i], zufallsnamen[zufallszahl2]); 
                  

                     lZeit = runTime[i];
                    randomName = zufallsnamen[zufallszahl2];

                    
                 }




            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////Der schnellste Läufer ist " + lauferListe[0] + "s//////////////////////"  );
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");



        }
    }
}
