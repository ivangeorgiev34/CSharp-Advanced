using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            Func<int[], int> minNumber = numbers =>
             {
                 int min = int.MaxValue;
                 for (int i = 0; i < numbers.Length; i++)
                 {
                     if (numbers[i] < min)
                     {
                         min = numbers[i];
                     }
                 }
                 return min;
             };
            Console.WriteLine(minNumber(numbers));
        }
    }
}
