namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
            int max = int.MinValue;
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + 1 < rows && col + 1 < cols)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > max)
                        {
                            first = matrix[row, col];
                            second = matrix[row, col + 1];
                            third = matrix[row + 1, col];
                            fourth = matrix[row + 1, col + 1];
                            max = sum;
                        }
                    }
                }
            }
            Console.WriteLine($"{first} {second}");
            Console.WriteLine($"{third} {fourth}");
            Console.WriteLine(max);
        }
    }
}