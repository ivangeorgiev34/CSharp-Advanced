using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //4, 2, 1, 3, 5, 7, 1, 4, 2, 12
            Console.WriteLine(string.Join(", ",Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray())) ;
        }
    }
}
