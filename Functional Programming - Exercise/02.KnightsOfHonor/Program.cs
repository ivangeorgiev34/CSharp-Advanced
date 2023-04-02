using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = (k) =>
            {
                foreach (var item in k)
                {
                    Console.WriteLine($"Sir {item}");
                }
            };
            string[] knights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(knights);
        }
    }
}
