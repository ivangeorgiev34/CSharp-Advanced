using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, string> function = n => (n * 1.2D).ToString("f2");
            //1.38, 2.56, 4.4
            Console.WriteLine(string.Join(Environment.NewLine, (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).Select(function).ToArray())));
        }

    }

}
