using System;

namespace _05.__Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += username[i];
            }

            int totalTries = 0;
            string enteredPassowrd;

            while ((enteredPassowrd = Console.ReadLine()) != password)
            {
                totalTries++;
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
            }

            if (totalTries < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            

        }
    }
}
