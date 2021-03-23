using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
    }
}
