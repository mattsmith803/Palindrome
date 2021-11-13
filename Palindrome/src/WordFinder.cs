using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    public class WordFinder
    {
        public static void ExecuteFindUniqueWords(string paragraph)
        {
            var wordsToCounts = FindUniqueWordsAndCounts(paragraph);

            Console.WriteLine("Total Unique Words: " + wordsToCounts.Count);
            foreach (var uniqueWord in wordsToCounts.OrderBy(w => w.Key))
            {
                Console.WriteLine($"{uniqueWord.Key,15}: {uniqueWord.Value,-2}"); // numbers are minimum number of length string, positive right aligns, negative left aligns
            }
        }
        public static Dictionary<string, int> FindUniqueWordsAndCounts(string paragraph)
        {
            Dictionary<string, int> wordsToCounts = new Dictionary<string, int>();

            if (paragraph == "")
            {
                return wordsToCounts;
            }

            paragraph = Helpers.SanitizeString(paragraph);

            foreach (var word in paragraph.Split(' '))
            {
                if (word == "")
                {
                    continue;
                }

                if (!wordsToCounts.ContainsKey(word))
                {
                    wordsToCounts.Add(word, 0);
                }

                wordsToCounts[word] = wordsToCounts[word] + 1;
            }

            return wordsToCounts;
        }

        public static void ExecuteFindWordsWithLetter(string paragraph, string letter)
        {
            List<string> wordsWithLetter = FindWordsWithLetter(paragraph, letter);

            Console.WriteLine($"Words with letter '{letter}'");

            if (wordsWithLetter.Count == 0)
            {
                Console.WriteLine($"No words with letter '{letter}' found");
            }

            foreach (var word in wordsWithLetter)
            {
                Console.WriteLine($"\t{word}");
            }

        }

        public static List<string> FindWordsWithLetter(string paragraph, string letter)
        {
            List<string> wordsWithLetter = new List<string>();

            if (letter == "" || letter == " ")
            {
                return wordsWithLetter;
            }

            paragraph = Helpers.SanitizeString(paragraph);

            foreach (var word in paragraph.Split(' '))
            {
                if (word == "")
                {
                    continue;
                }

                if (word.ToLower().Contains(letter.ToLower()))
                {
                    wordsWithLetter.Add(word);
                }
            }

            return wordsWithLetter;

        }
    }
}