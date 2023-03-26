using System;
using System.IO;

namespace _04.MergeTextFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader firstReader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondReader = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {

                        while (!firstReader.EndOfStream || !secondReader.EndOfStream)
                        {
                            if (firstReader.EndOfStream)
                            {
                                while (!secondReader.EndOfStream)
                                {
                                    writer.WriteLine(secondReader.ReadLine());
                                }
                                break;
                            }
                            if (secondReader.EndOfStream)
                            {
                                while (!firstReader.EndOfStream)
                                {
                                    writer.WriteLine(firstReader.ReadLine());
                                }
                                break;
                            }
                            string currentFirstLine = firstReader.ReadLine();
                            string currentSecondLine = secondReader.ReadLine();
                            writer.WriteLine(currentFirstLine);
                            writer.WriteLine(currentSecondLine);
                        }
                    }
                }
            }
        }
    }
}

