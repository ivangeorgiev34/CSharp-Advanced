using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            Func<int[],int[]> add = nums =>
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i]++;
                }
                return nums;
            };
            Func<int[], int[]> multiply = nums =>
             {
                 for (int i = 0; i < nums.Length; i++)
                 {
                     nums[i] = nums[i] * 2;
                 }
                 return nums;
             };
            Func<int[], int[]> subtract = nums =>
             {
                 for (int i = 0; i < nums.Length; i++)
                 {
                     nums[i] = nums[i] - 1;
                 }
                 return nums;
             };
            Action<int[]> print = nums => Console.WriteLine(string.Join(" ",nums));
            string command = Console.ReadLine();
            while (command!="end")
            {
                switch (command)
                {
                    case "add":
                        add(numbers);
                        break;
                    case "multiply":
                        multiply(numbers);
                        break;
                    case "subtract":
                        subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
