namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string continent = tokens[0];
                string country = tokens[1];
                string town = tokens[2];
                if (!dictionary.ContainsKey(continent))
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent].Add(country, new List<string>());
                }
                dictionary[continent][country].Add(town);
            }
            foreach (var continent in dictionary)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var item in continent.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}