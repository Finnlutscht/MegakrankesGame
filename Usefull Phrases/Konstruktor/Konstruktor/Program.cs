using System;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------Konstruktor----------------------------------------------------------
            //Code duplizierung wird vermieden man muss nicht Alles neu deklarieren (neue Variablen)
            //f hinter Wert bei datentyp float, ist quasi double nur ungenauer somit Speichersparender
            Mensch JuJu = new Mensch(1.86f, 68.3f );
            Console.WriteLine("JuJu ist " + JuJu.height + "m groß");
            Console.WriteLine("JuJu ist " + JuJu.weight + "kg schwer");
            Console.ReadKey();
            //Beep macht ein lustiges Beep geräusch :^)
            Console.Beep();

            Mensch Finn = new Mensch(1.89f, 71.4f);
            Console.WriteLine("Finn ist " + Finn.height + "m groß");
            Console.WriteLine("Finn ist " + Finn.weight + "kg schwer");
            Console.ReadKey();
            Console.Beep();

            Mensch Max = new Mensch(1.89f, 67.3f);
            Console.WriteLine("Max ist " + Max.height +"m groß");
            Console.WriteLine("Max ist " + Max.weight + "kg schwer");
            Console.ReadKey();
            Console.Beep();        
        }

    }


    class Mensch
    {
        //Variablen
        public float height { get; set; }
        public float weight{ get; set; }

        //Konstruktor
        public Mensch(float pheight, float pweight)
        {
            height = pheight;
            weight = pweight;
        }
    }
}


