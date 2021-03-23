using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string help = "";

            bool isBlocked = false;
            string input = Console.ReadLine();

            for (int i = pass.Length-1; i >= 0; i--)
            {
                help += pass[i];
            }
            int tryies = 0;
            while (input != help)
            {
                
                tryies++;
                if (tryies == 4)
                {
                    Console.WriteLine("User sunny blocked!");
                    isBlocked = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                input = Console.ReadLine();
            }
            if (isBlocked == false)
            {
                Console.WriteLine($"User {pass} logged in.");
            }
        }
    }
}
