using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            StringBuilder list = new StringBuilder();

            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (i != 0)
                {
                    if (input[i - 1] == '>')
                    {
                        sum += int.Parse(input[i].ToString());
                    }

                    if (sum > 0)
                    {
                        sum--;
                    }
                    else
                    {
                        list.Append(input[i]);
                    }
                    
                }
                else
                {
                    list.Append(input[i]);
                }

            }
            foreach (var item in list.ToString())
            {
                Console.Write(item);
            }
        }
    }
}
