using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                list.Add(new Person { Name = arr[0], Age = int.Parse(arr[1]) });
            }
            string olderOrYounger = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<Person, string, int, bool> func = (person,str, age) => str == "older" ? person.Age >= age : person.Age < age;
            Func<Person, string[], string> func1 = (person, str) =>
              {
                  string formatter = string.Empty;
                  if (str.Length == 2)
                  {
                      if (str[0] == "name")
                      {
                          formatter = $"{person.Name} - {person.Age}";
                      }
                      else
                      {
                          formatter = $"{person.Age} - {person.Name}";
                      }
                  }
                  else
                  {
                      if (str[0] == "name")
                      {
                          formatter = $"{person.Name}";
                      }
                      else
                      {
                          formatter = $"{person.Age}";
                      }
                  }
                  return formatter;
              };
            Console.WriteLine(string.Join(Environment.NewLine, list.Where(person => func(person, olderOrYounger, num)).Select(s => func1(s,tokens))));
        }
    }
}
