using System;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    if (count < 30)
                    {
                        Console.WriteLine($"Total price: {(8.45 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((8.45 * count) * 0.85):f2}");
                    }
                }
                else if (type == "Business")
                {
                    if (count < 100)
                    {
                        Console.WriteLine($"Total price: {(10.90 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((10.90 * count) - (10 * 10.90)):f2}");
                    }
                }
                else if (type == "Regular")
                {
                    if (count >= 10 && count <= 20)
                    {
                        Console.WriteLine($"Total price: {((15 * count) * 0.95):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(15 * count):f2}");
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    if (count < 30)
                    {
                        Console.WriteLine($"Total price: {(9.80 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((9.80 * count) * 0.85):f2}");
                    }
                }
                else if (type == "Business")
                {
                    if (count < 100)
                    {
                        Console.WriteLine($"Total price: {(15.60 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((15.60 * count) - (10 * 15.60)):f2}");
                    }
                }
                else if (type == "Regular")
                {
                    if (count >= 10 && count <= 20)
                    {
                        Console.WriteLine($"Total price: {((20 * count) * 0.95):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(20 * count):f2}");
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    if (count < 30)
                    {
                        Console.WriteLine($"Total price: {(10.46 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((10.46 * count) * 0.85):f2}");
                    }
                }
                else if (type == "Business")
                {
                    if (count < 100)
                    {
                        Console.WriteLine($"Total price: {(16.00 * count):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {((16.00 * count) - (10 * 16.00)):f2}");
                    }
                }
                else if (type == "Regular")
                {
                    if (count >= 10 && count <= 20)
                    {
                        Console.WriteLine($"Total price: {((22.5 * count) * 0.95):f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(22.5 * count):f2}");
                    }
                }
            }
        }
    }
}
