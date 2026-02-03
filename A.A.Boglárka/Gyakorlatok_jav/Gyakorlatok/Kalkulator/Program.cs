namespace Kalkulator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Add\n2. Subtract\n3 Multiply\n4 Division");
            char choice = char.Parse(Console.ReadLine());
            int a = 10, b = 5;
            switch (choice)
            {
                case 'a':
                    Console.WriteLine("Sum: " + (a + b));
                    break;
                case 's':
                    Console.WriteLine("Difference: " + (a - b));
                    break;
                case 'm':
                    Console.WriteLine("Product: " + (a * b));
                    break;
                case 'd':
                    Console.WriteLine("Quotient: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
