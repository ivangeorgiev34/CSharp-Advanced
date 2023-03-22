namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    if (int.Parse(tokens[1]) < n && int.Parse(tokens[2]) < n && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[2]) >= 0)
                    {
                        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] + int.Parse(tokens[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (tokens[0] == "Subtract")
                {
                    if (int.Parse(tokens[1]) < n && int.Parse(tokens[2]) < n && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[2]) >= 0)
                    {
                        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] - int.Parse(tokens[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}