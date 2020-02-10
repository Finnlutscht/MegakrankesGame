using System;
using System.Collections.Generic;
using System.Linq;

namespace Zufallszeugs
{
    //Klasse Läufer mit Parameter für Zeit und Name
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
            int zufallszahl;
            int zufallszahl2;
            string randomName = "0";
            int lZeit = 0;
            
            //Array zum Vergleichen (aussortieren) der Zeiten und Liste zum einsortieren
            string[] generatedNames = new string[50];
            List<string> lauferListe = new List<string>();

       
           
            //Wichtig : for Schleife ruft Methode auf und Methode sich selbst für Loop
            for (int i = 0; i < 5; i++)
            {
                     Zufallsnamen();
                     proof();   
                generatedNames[i] = randomName;
            }

            //Prüft ob Name schon vergeben wurde, falls ja wird neuer Name generiert und wieder geprüft,
            //bis einer der noch nicht Vergeben wurde generiert wird
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
                lauferListe.Add(lZeit + "s von " + randomName);                  
                }
                
        }


            Console.WriteLine("-----------------------------Lauferergebnisse------------------------------");

            foreach (string value in lauferListe)
            {
            Console.WriteLine(value);

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

                //Array mit allen Namen
                string[] zufallsnamen = new string[8];
                zufallsnamen[0] = "Max";
                zufallsnamen[1] = "Julius";
                zufallsnamen[2] = "Finn";
                zufallsnamen[3] = "Victoria";
                zufallsnamen[4] = "Angela Merkel";
                zufallsnamen[5] = "Kobe Bryant";
                zufallsnamen[6] = "die hässliche Schildkröte";
                zufallsnamen[7] = "Flo";               

                //unnötigste for Schleife EU, bestimmt einfach nen Zufallswert wir waren nur zu faul zu ändern
                for (int i = 1; i < 2; i++)
                {
                    //Zufallszahl zwischen 10, 20 für Zeit und 0, 8 für Namen
                    zufallszahl = rnd.Next(10, 20);
                    zufallszahl2 = rnd.Next(0, 8);

                    runTime[i] = zufallszahl;

                    //neuer Laufer (Objekt) mit Zufallszahlen wir erzeugt
                    Laufer l = new Laufer(runTime[i], zufallsnamen[zufallszahl2]); 
                  
                    //Variablen zur weitergabe des Namen und der Zeit
                     lZeit = runTime[i];
                    randomName = zufallsnamen[zufallszahl2];                  
                 }




            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////Die schnellste Zeit ist " + lauferListe[0] + "///////////////////////"  );
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");



        }
    }
}
