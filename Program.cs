using System;

namespace oddSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which is the number you want to calculate?");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine("On which power to stop?");
            int powers = int.Parse(Console.ReadLine());

            double sum = 0;
            double son;

            for(int i = 1; i <= powers; i++)
            {
                son = Math.Pow(input, i);
                if (son % 2 != 0)
                {
                    Console.WriteLine(son);
                    sum += son;
                }
            }

            Console.WriteLine($"The results is {sum}.");
        }
    }
}