using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).Count());
            Console.WriteLine(input.Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).Sum());
        }
    }
}
