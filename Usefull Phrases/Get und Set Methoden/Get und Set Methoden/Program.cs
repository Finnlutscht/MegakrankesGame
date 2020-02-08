using System;

namespace Get_und_Set_Methoden
{
    class Programm
    {
        static void Main(string[] args)
        {
            int Alter = 0;
            Console.WriteLine("Ursprüngliches alter " + Alter);
            Person peter = new Person();
            peter.Alter = 10;
            Console.WriteLine(peter.Alter);
            Console.ReadKey();
        }
    }


    class Person
    {
            private int alter;

            public int Alter
            {
                get
                {
                    Console.WriteLine("Alter wurde gelesen");
                    return alter;
                }
                set
                {
                    Console.WriteLine("Alter wurde überschrieben");
                    alter = value;
                }
            }
    }
}
