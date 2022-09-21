using System;

namespace _06._StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // modular division by 10 -> return last digit
            // integer division by 10 -> removes last digit

            int numCopy = n;
            int factorialSum = 0;

            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;

            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
