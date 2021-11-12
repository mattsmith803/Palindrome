namespace Palindrome
{
    public class UniqueWords
    {
        public static void ExecuteUniqueWords(string paragraph)
        {
            var wordsToCounts = FindUniqueWordsAndCounts(paragraph);

            Console.WriteLine("Total Unique Words: " + wordsToCounts.Count);
            foreach (var uniqueWord in wordsToCounts.OrderBy(w => w.Key))
            {
                Console.WriteLine(uniqueWord.Key + ": " + uniqueWord.Value);
            }
        }
        public static Dictionary<string, int> FindUniqueWordsAndCounts(string paragraph)
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

            return wordsToCounts;
        }
    }
}