using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            HashSet<string> wordsToFind = new HashSet<string>();
            var wordReader = new StreamReader(wordsFilePath);
            using (wordReader)
            {
                wordsToFind = wordReader.ReadToEnd()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToHashSet();
                foreach (string word in wordsToFind)
                {
                    wordCounts.Add(word, 0);
                }
            }
            var textReader = new StreamReader(textFilePath);
            string pattern = @"[a-z]+";
            Regex regex = new Regex(pattern);
            using (textReader)
            {

                while (true)
                {
                    string line = textReader.ReadLine();
                    if (line == null) break;
                    string[] wordsInLine = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    List<Match> matches = new List<Match>();
                    foreach (string word in wordsInLine)
                    {
                        Match match = regex.Match(word);
                        if (match.Success)
                        {
                            matches.Add(match);
                        }
                    }
                    foreach (Match match in matches)
                    {
                        foreach (var w in wordsToFind)
                        {
                            if (match.Value == w)
                            {
                                wordCounts[w]++;
                            }
                        }
                    }
                }
            }

            wordCounts = wordCounts
                .OrderByDescending(w => w.Value)
                .ToDictionary(w => w.Key, w => w.Value);
            var writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                foreach (var word in wordCounts)
                {
                    string line = $"{word.Key} - {word.Value}";
                    writer.WriteLine(line);
                }
            }

        }
    }
}

