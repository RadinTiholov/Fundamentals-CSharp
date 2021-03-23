using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _6._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }

        }
    }
}
