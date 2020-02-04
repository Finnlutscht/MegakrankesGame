using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masterpiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int zahl1 = 10 / 3;
        int zahl2 = 10 % 3;

        Console.WriteLine(zahl1);
        Console.WriteLine(zahl2);

        // -----------------------SWITCH-------------------------------------------------------------------------
        string zahls = "Hallo";
        switch (zahls)
        {

            case "halo":
                Console.WriteLine("zahl hat den Wert 1");
                break;

            case "hallo":
                Console.WriteLine("zahl hat den Wert 2");

                break;

            default:
                Console.WriteLine("die zahl hat einen anderen Wert");

                break;
        }
        Console.WriteLine("Das war switch!(Z.16)");
        Console.ReadKey();
        //-----------------IF-ANWEISUNG-------------------------------------------------------------------------------------------
        Boolean fair = true;

        if (fair == true)
        {
            Console.WriteLine("Das Spiel ist fair");

        }
        else
        {
            Console.WriteLine("Das Spiel ist unfair!");
        }
        Console.WriteLine("Das waren die If-Anweisungen!(z.36)");
        Console.ReadKey();
        //-------------WHILE-SCHLEIFE/DO-WHILE-SCHLEIFE------------------------------------------------------------------------------------------------
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
        Console.WriteLine("Das waren die While-Schleifen!(Z.50)");
        Console.ReadKey();
        //---------------FOR-SCHLEIFE--------------------------------------------------------------------------------------------------------------------

        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine(i);

        }

        Console.WriteLine("Das waren die For-Schleifen!(Z.71)");
        Console.ReadKey();
        //-------------FOREACH-SCHLEIFE-----------------------------------------------------------------------------------------------------------------

        string[] namensListe = new string[3];

        namensListe[0] = "Max";
        namensListe[1] = "Finn";
        namensListe[2] = "Julius";

        foreach (string name in namensListe)
        {
            Console.WriteLine(name);

        }
        Console.WriteLine("Das war die Foreach-Schleife(Z.82)");
        Console.ReadKey();

        //-------------1D-ARRAY-------------------------------------------------------------------------------------------------------------------------

        string[] namenListe = new string[3];

        namenListe[0] = "Finn";
        namenListe[1] = "Max";
        namenListe[2] = "Julius";
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(namenListe[i]);

        }
        Console.WriteLine("Das waren die 1D-Arrays!(Z.83)");
        Console.ReadKey();

        //--------------------2D-ARRAYS------------------------------------------------------------------------------------------------------

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
        Console.WriteLine("Das waren die 2D-Arrays!(Z.98)");
        Console.ReadKey();


        //Aufruf der Methode "neueMethode"
        neueMethode(16, "Julius");

        //Aufruf der Methode "Addition"
        int ausgabeZahl = Addition(10, 5);
        Console.WriteLine(ausgabeZahl);
        Console.ReadKey();
        //So würde es auch gehen: Console.WriteLine(Adition(10, 5));
    }
    static void neueMethode(int alter, string name)
    {
        Console.WriteLine("Mein Alter ist " + alter + " und ich heiße " + name);
        Console.ReadKey();

    }

    static int Addition(int zahl1, int zahl2)
    {
        int ergebnis = zahl1 + zahl2;
        return ergebnis;
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
