namespace AvergeOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40 };
            //double avg = numbers.Average();
            //Console.WriteLine("Average: " + avg);

            int[] numbers;
            int tombhossz;
            string inputText;
            double avg;

            Console.WriteLine("Adjunk be egész számokat");
            Console.WriteLine("Hány számot olvassunk be?: ");
            inputText = Console.ReadLine();
            tombhossz = Convert.ToInt32(inputText);

            numbers = new int[tombhossz];

            for (int i = 0; i < tombhossz; i++)
            {
                Console.Write($"kérjük a {i}-edik számot: ");
                inputText = Console.ReadLine();
                numbers[i] = Convert.ToInt32(inputText);
            }

            avg = numbers.Average();
            Console.WriteLine("Average: " + avg);


            Console.WriteLine();
            Console.WriteLine("Enter-rel lehet kilépni!");
            Console.ReadLine();


        }
    }
}
