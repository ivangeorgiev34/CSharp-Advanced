using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            Func<int[], int, List<int>> filter = (nums, endOfRange) =>
               {
                   List<int> list = new List<int>();
                   bool flag = true;
                   for (int i = 1; i <= endOfRange; i++)
                   {
                       flag = true;
                       for (int j = 0; j < nums.Length; j++)
                       {
                           if (i % nums[j] != 0)
                           {
                               flag = false;
                           }
                       }
                       if (flag)
                       {
                           list.Add(i);
                       }
                   }
                   return list;
               };
           
            Console.WriteLine(string.Join(" ", filter(nums, endOfRange)));
        }
    }
}
