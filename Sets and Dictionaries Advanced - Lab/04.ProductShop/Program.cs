
namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                if (tokens[0] == "Revision")
                {
                    break;
                }
                string store = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);
                if (!dictionary.ContainsKey(store))
                {
                    dictionary.Add(store, new Dictionary<string, double>());
                }
                dictionary[store].Add(product, price);
            }
            dictionary = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var store in dictionary)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}