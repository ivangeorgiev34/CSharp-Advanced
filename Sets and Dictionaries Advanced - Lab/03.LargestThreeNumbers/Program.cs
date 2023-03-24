namespace _03.LargestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            input = input.OrderByDescending(n => n).ToArray();
            if (input.Length < 3)
            {
                Console.WriteLine(string.Join(" ", input));
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}