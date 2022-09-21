using System;

namespace _11.__Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int order = int.Parse(Console.ReadLine());
            
            double sum = 0;
            double totalSum = 0;


            for (int i = 1; i <= order; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                sum = price * days * count;
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}") ;
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }

    }
}
