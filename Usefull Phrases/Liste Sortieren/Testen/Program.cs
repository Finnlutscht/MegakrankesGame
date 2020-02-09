using System;
using System.Collections.Generic;

namespace Testen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 53, 2, 23, 6, 7, 9 };
            Console.WriteLine("Before Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }



            Mensch Finn = new Mensch(188, "Finn");
            Mensch JuJu = new Mensch(186, "Julius");
            Mensch Max = new Mensch(189, "Max");


            List<int> heightlist = new List<int>();

            heightlist.Add(JuJu.height);
            heightlist.Add(Max.height);
            heightlist.Add(Finn.height);
            

            Console.WriteLine("vor sortieren nach height");
            foreach (int height in heightlist)
            {
                Console.WriteLine(height);
            }
            Console.ReadKey();

            Console.WriteLine("Nach sortieren nach height");
            heightlist.Sort();

            foreach (int height in heightlist)
            {
                Console.WriteLine(height);
            }
            Console.ReadKey();


            List<string> namelist = new List<string>();

            namelist.Add(JuJu.name);
            namelist.Add(Max.name);
            namelist.Add(Finn.name);

            Console.WriteLine("vor sortieren nach Name");
            foreach (string name in namelist)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

            namelist.Sort();

            Console.WriteLine("nach sortieren nach Name");
            foreach (string name in namelist)
            {
                Console.WriteLine(name);
            }



            



        }
    }



    class Mensch
    {
        public int height { get; set; }
        public string name { get; set; }

        public Mensch(int pheight, string pname)
        {
            height = pheight;
            name = pname;
        }
    }
    





}
