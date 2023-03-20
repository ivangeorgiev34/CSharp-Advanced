namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string input = Console.ReadLine();
            foreach (char character in input)
            {
                stack.Push(character.ToString());
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}