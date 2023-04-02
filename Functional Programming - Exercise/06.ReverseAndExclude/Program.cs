using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            List<int> list = new List<int>(arr);
            list.Reverse();
            int n = int.Parse(Console.ReadLine());
            Func<List<int>, int, List<int>> function = (nums, n) =>
              {
                  for (int i = 0; i < nums.Count; i++)
                  {
                      if (nums[i] % n == 0)
                      {
                          nums.RemoveAt(i);
                          i--;
                      }
                  }
                  return nums;
              };
            function(list, n);
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
