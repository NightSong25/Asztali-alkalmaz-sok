using System;

namespace Szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int veletlenszam = r.Next(1,100);
            int tipp = 0;
            bool eltalaltuk = false;
            string inputText = "";

            Console.WriteLine("Számkitaláló játék!");
            Console.WriteLine("Gondoltam egy számot 1-100 között. Mi az?!");
            /*
             while()
            {
            }
            */

            //do-while verzióval
            do
            {
                Console.Write("Kérek egy tippet: ");
                inputText = Console.ReadLine();
                tipp = int.Parse(inputText);
                if (tipp < veletlenszam)
                {
                    Console.Write("A szám nagyobb, mint a tipp volt!");
                }
                else
                {
                    if(tipp > veletlenszam);
                    {

                    }
                    Console.Write("A szám kisebb, mint a tipp volt!");
                }

            }
            while (!eltalaltuk);

            //Console.WriteLine($"Egy véletlen szám: {Random.Next(1, 100)}");
            Console.WriteLine();
            Console.WriteLine("Enter-rel lehet kilépni!");
            Console.ReadLine();
        }
    }
}
