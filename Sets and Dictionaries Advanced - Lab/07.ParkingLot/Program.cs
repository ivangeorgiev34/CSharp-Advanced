using System.Text.RegularExpressions;

namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = Regex.Split(input, ", ");

                if (tokens[0] == "IN")
                {
                    numbers.Add(tokens[1]);
                }
                else if (tokens[0] == "OUT")
                {
                    numbers.Remove(tokens[1]);
                }
                input = Console.ReadLine();
            }
            if (numbers.Count > 0)
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}