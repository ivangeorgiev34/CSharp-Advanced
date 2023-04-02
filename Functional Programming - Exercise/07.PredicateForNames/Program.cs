using System;
using System.Collections.Generic;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>(names);
            Action<List<string>, int> print = (list, n) =>
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     if (list[i].Length <= n)
                     {
                         Console.WriteLine(list[i]);
                     }
                 }
             };
            print(list,n);
        }
    }
}
