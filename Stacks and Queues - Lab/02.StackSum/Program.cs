namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string command = Console.ReadLine().ToLower();
            Stack<string> stack = new Stack<string>(input);
            bool flag = false;
            int sum = 0;
            while (command != "end")
            {
                string[] tokens = command.Split(" ");
                switch (tokens[0].ToLower())
                {
                    case "add":
                        stack.Push(tokens[1]);
                        stack.Push(tokens[2]);
                        break;
                    case "remove":
                        if (int.Parse(tokens[1]) > stack.Count)
                        {
                            break;
                        }
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            stack.Pop();
                        }
                        break;
                }
                if (flag)
                {
                    break;
                }
                command = Console.ReadLine().ToLower();
            }
            while (stack.Count > 0)
            {
                int currentNumber = int.Parse(stack.Pop());
                sum = sum + currentNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}