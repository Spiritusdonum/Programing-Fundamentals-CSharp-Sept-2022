using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double startingMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());
            
            double moneyNeeded = (students + (Math.Ceiling(0.1* students))) * lightsabers + students * robes + (students - students/6) * belt ;
                     
            if (moneyNeeded <= startingMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(startingMoney - moneyNeeded):f2}lv more.");
            }

           



        }
    }
}
