using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = x => x[0].ToString() == x[0].ToString().ToUpper();
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>x).Where(func)));
        }
    }
}
