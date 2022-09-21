using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = Math.Floor((lostGames / 2) * headsetPrice) + Math.Floor((lostGames / 3) * mousePrice) + Math.Floor((lostGames / 6) * keyboardPrice) + Math.Floor((lostGames / 12) * displayPrice);

            Console.WriteLine($"Rage expenses: {(expenses):f2} lv.");
        }
    }
}
