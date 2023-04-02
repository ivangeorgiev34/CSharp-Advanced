using System;
using System.Collections.Generic;

namespace _010.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            string[] tokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<string> filters = new List<string>();
            Func<List<string>, string, List<string>> startsWith = (list, str) =>
              {
                  for (int i = 0; i < list.Count; i++)
                  {
                      bool flag = true;
                      for (int j = 0; j < str.Length; j++)
                      {
                          if (list[i][j] != str[j])
                          {
                              flag = false;
                          }
                      }
                      if (flag)
                      {
                          list.RemoveAt(i);
                          i--;
                      }
                  }
                  return list;
              };
            Func<List<string>, string, List<string>> endsWith = (list, str) =>
              {
                  for (int i = 0; i < list.Count; i++)
                  {
                      bool flag = true;
                      for (int j = str.Length-1, k = list[i].Length-1; j >=0 ; j--,k--)
                      {
                          if (str[j] != list[i][k])
                          {
                              flag = false;
                          }
                      }
                      if (flag)
                      {
                          list.RemoveAt(i);
                          i--;
                      }

                  }
                  return list;
              };
            Func<List<string>, string, List<string>> length = (list, str) =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Length == int.Parse(str))
                    {                   
                            list.RemoveAt(i);
                    }
                }
                return list;
            };
            Func<List<string>, string, List<string>> contains = (list, str) =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Contains(str))
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }
                return list;
            };
            while (tokens[0] != "Print")
            {
                if (tokens[0] == "Add filter")
                {
                    filters.Add($"{tokens[1]} {tokens[2]}");
                }
                else if (tokens[0] == "Remove filter")
                {
                    filters.Remove($"{tokens[1]} {tokens[2]}");
                }
                tokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < filters.Count; i++)
            {
                string[] arr = filters[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (arr[0] == "Starts")
                {
                    list = startsWith(list, arr[2]);
                }
                else if (arr[0] == "Ends")
                {
                    list = endsWith(list, arr[2]);
                }
                else if (arr[0] == "Length")
                {
                    list = length(list, arr[1]);
                }
                else if (arr[0] == "Contains")
                {
                    list = contains(list, arr[1]);
                }
            }
            Console.WriteLine(string.Join(" ",list));

        }
    }
}
