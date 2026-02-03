using System;

    namespace AtlagSzamitas 
    { 
    
        class Program
        {
            static void Main()
            {
                int a, b, c, sum;
                double avg;
                string inputTxt;
                Console.WriteLine("Adj meg 3 egész számot: ");
                Console.WriteLine("Kiszámolom az átlagukat");
                Console.WriteLine("Adj meg egy egész számot: ");
                inputTxt = Console.ReadLine();
                int.TryParse(inputTxt, out a);

                Console.WriteLine("Adj meg egy egész számot: ");
                inputTxt = Console.ReadLine();
                b = int.Parse(inputTxt);

                Console.WriteLine("Adj meg egy egész számot: ");
                inputTxt = Console.ReadLine();
                int.TryParse(inputTxt, out c);

                sum = a + b + c;

                avg = sum / 3;

                Console.WriteLine($"A 3 szám átlaga: {avg}");
                Console.ReadLine();

            }


        }


    }