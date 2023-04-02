using System;
using System.Collections.Generic;
using System.Linq;

namespace _011.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>(names);
            Func<string, int, bool> checkValidUsername = (name, num) =>
              {
                  int sum = 0;
                  for (int i = 0; i < name.Length; i++)
                  {
                      sum = sum + (int)name[i];
                  }
                  if (sum >= num)
                  {
                      return true;
                  }
                  return false;                 
              };
            Func<Func<string, int,bool>, List<string>, int, string> firstOrDefault = (f, list, s) =>  list.FirstOrDefault(name => f(name, s));
            Console.WriteLine(firstOrDefault(checkValidUsername,list,n));
        }
    }
}
