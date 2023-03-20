namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            int a = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                stack.Push(expression[i]);
                int result = 0;
                if (stack.Count == 3)
                {
                    int firstNumber = int.Parse(stack.Pop());
                    var operation = stack.Pop();
                    int secondNumber = int.Parse(stack.Pop());// 2 + 5 + 10 - 2 - 1
                    if (operation == "+")
                    {
                        result = firstNumber + secondNumber;
                    }
                    else if (operation == "-")
                    {
                        result = secondNumber - firstNumber;
                    }
                    stack.Push(result.ToString());
                }

            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}