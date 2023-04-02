using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine,strings));
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(names);
        }
    }
}
