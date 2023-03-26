using System;
using System.IO;

namespace _02.OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int row = 1;
            using (reader)
            {
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        string currentLine = reader.ReadLine();
                        if (row % 2 != 0)
                        {
                            writer.WriteLine(currentLine);
                        }
                        row++;
                    }
                }
            }
        }
    }
}

