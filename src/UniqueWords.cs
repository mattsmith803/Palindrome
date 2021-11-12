namespace Palindrome
{
    public class UniqueWords
    {
        public static void FindAndPrintUniqueWordsAndCounts(string paragraph)
        {

            Dictionary<string, int> wordsToCounts = new Dictionary<string, int>();

            foreach (var word in paragraph.Split(' '))
            {

                if (!wordsToCounts.ContainsKey(word))
                {
                    wordsToCounts.Add(word, 0);
                }

                wordsToCounts[word] = wordsToCounts[word] + 1;
            }

            Console.WriteLine("Total Unique Words: " + wordsToCounts.Count);
            foreach (var uniqueWord in wordsToCounts.OrderBy(w => w.Key))
            {
                Console.WriteLine(uniqueWord.Key + ": " + uniqueWord.Value);
            }

        }
    }
}