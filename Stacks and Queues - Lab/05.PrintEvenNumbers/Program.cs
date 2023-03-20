namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0)
                {
                    queue.Enqueue(int.Parse(numbers[i]));
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}