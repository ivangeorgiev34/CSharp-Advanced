namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = -1;
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    while (input != "End")
                    {
                        input = Console.ReadLine();
                        counter++;
                    }
                    break;
                }
                queue.Enqueue(input);
                input = Console.ReadLine();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine($"{counter} people remaining.");
            }
            else
            {
                Console.WriteLine($"{queue.Count} people remaining.");
            }
        }
    }
}