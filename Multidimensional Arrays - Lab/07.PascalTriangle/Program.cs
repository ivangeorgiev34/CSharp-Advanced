namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[n][];
            for (int row = 0; row < n; row++)
            {
                jaggedArray[row] = new long[row + 1];
                if (row == 0)
                {
                    jaggedArray[row][row] = 1;
                    continue;
                }
                for (int i = 0; i <= row; i++)
                {
                    if (i == 0)
                    {
                        jaggedArray[row][i] = 1;
                        continue;
                    }
                    if (i == row)
                    {
                        jaggedArray[row][i] = 1;
                        continue;
                    }
                    jaggedArray[row][i] = jaggedArray[row - 1][i] + jaggedArray[row - 1][i - 1];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}