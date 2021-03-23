using System;
using System.Linq;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            PassValidator(pass);
        }
        static void PassValidator(string pass)
        { 
            if (pass.Count(Char.IsDigit) >= 2 && pass.Length >= 6 && pass.Length <= 10 && pass.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }
            else 
            {
                if (!(pass.Length >= 6 && pass.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!pass.All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!(pass.Count(Char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
        }
    }
}
