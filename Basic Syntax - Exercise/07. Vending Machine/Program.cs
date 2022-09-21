using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coin;
            double coinSum = 0;

            string input = Console.ReadLine();
           
            while (input != "Start")
            {
                coin = double.Parse(input);
                switch (coin)
                {
                    case 0.1:
                    coinSum += 0.1;
                    break;
                    case 0.2:
                    coinSum += 0.2;
                    break;
                    case 0.5:
                    coinSum += 0.5;
                    break;
                    case 1:
                    coinSum += 1;
                    break;
                    case 2:
                    coinSum += 2;
                    break;
                    default:
                    Console.WriteLine($"Cannot accept {coin}");
                    break;
                }

                input = Console.ReadLine();
            }

            string obj = string.Empty;
            input = Console.ReadLine();

            while (input != "End")
            {
                obj = input;
                switch (obj)
                {
                    case "Nuts":
                        if (coinSum >= 2)
                        {
                        coinSum -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coinSum >= 0.7)
                        {
                            coinSum -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coinSum >= 1.5)
                        {
                            coinSum -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coinSum >= 0.8)
                        {
                            coinSum -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coinSum >= 1.0)
                        {
                            coinSum -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinSum:f2}");

        }
    }
}
