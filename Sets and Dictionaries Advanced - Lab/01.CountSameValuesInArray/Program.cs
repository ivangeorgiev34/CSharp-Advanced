namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            foreach (double item in input)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                }

                dictionary[item] = dictionary[item] + 1;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}