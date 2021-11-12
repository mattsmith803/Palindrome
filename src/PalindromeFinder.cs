namespace Palindrome
{
    public class PalindromeFinder
    {
        public static void CountPalindroneWords(string paragraph)
        {
            var words = paragraph.Split(' ');
            Console.WriteLine("Total number of words: " + words.Length);

            var count = 0;
            foreach (var word in words)
            {
                if (IsPalidrone(word))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of palindrone words: " + count);
        }

        public static void CountPalindroneSentences(string paragraph)
        {
            var sentences = paragraph.Split(new string[] { ". " }, StringSplitOptions.None);
            Console.WriteLine("Total number of sentences: " + sentences.Length);

            var count = 0;
            foreach (var sentence in sentences)
            {
                if (IsPalidrone(Helpers.SanitizeString(sentence)))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of palindrone sentences: " + count);
        }

        private static bool IsPalidrone(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray).Replace(" ", "");

            if (input.Replace(" ", "") == reversed)
            {
                return true;
            }

            return false;
        }
    }
}