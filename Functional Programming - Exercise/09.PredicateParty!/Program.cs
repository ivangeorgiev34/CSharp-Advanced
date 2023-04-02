using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, List<string>, string, List<string>> remover = (operation, list, str) =>
             {

                 if (operation == "StartsWith")
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

                 }
                 else if (operation == "EndsWith")
                 {
                     for (int i = 0; i < list.Count; i++)
                     {
                         bool flag = true;
                         for (int j = str.Length - 1, k = list[i].Length - 1; j >= 0; j--, k--)// peter eter
                          {
                             if (list[i][k] != str[j])
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
                 }
                 else if (operation == "Length")
                 {
                     for (int i = 0; i < list.Count; i++)
                     {
                         if (list[i].Length == int.Parse(str))
                         {
                             list.RemoveAt(i);
                             i--;
                         }
                     }
                 }

                 return list;
             };
            Func<string, List<string>, string, List<string>> doubler = (operation, list, str) =>
            {

                if (operation == "StartsWith")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        bool flag = true;
                        string currentName = list[i];
                        for (int j = 0; j < str.Length; j++)
                        {
                           
                            if (list[i][j] != str[j])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            list.Insert(i,currentName);
                            i++;
                        }
                    }

                }
                else if (operation == "EndsWith")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        string currentName = list[i];
                        bool flag = true;
                        for (int j = str.Length - 1, k = list[i].Length - 1; j >= 0; j--, k--)// peter eter
                        {
                            if (list[i][k] != str[j])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            list.Insert(i,currentName);
                            i++;
                        }
                    }
                }
                else if (operation == "Length")
                {
                   
                    for (int i = 0; i < list.Count; i++)
                    {
                        string currentName = list[i];
                        if (list[i].Length == int.Parse(str))
                        {
                            list.Insert(i,currentName);
                            i++;
                        }
                    }
                }
                return list;
            };




            while (commands[0] != "Party!")
            {
                if (commands[0] == "Remove")
                {
                   list =  remover(commands[1], list, commands[2]);
                }
                else if (commands[0] == "Double")
                {
                    list = doubler(commands[1], list, commands[2]);
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (list.Count == 0)
            {
                Console.WriteLine($"Nobody is going to the party!");
                return;
            }
            Console.Write(string.Join(", ",list));
            Console.Write(" are going to the party!");
        }
    }
}
