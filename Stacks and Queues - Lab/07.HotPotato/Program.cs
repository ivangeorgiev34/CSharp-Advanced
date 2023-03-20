namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);
            int toss = 1;
            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                if (toss == n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    toss = 1;
                    continue;
                }
                queue.Enqueue(currentKid);
                toss++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}