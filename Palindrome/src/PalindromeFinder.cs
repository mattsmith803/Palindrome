namespace Palindrome
{
    public class PalindromeFinder
    {
        public static void CountPalindromeWords(string paragraph)
        {
            var words = paragraph.Split(' ');
            Console.WriteLine("Total number of words: " + words.Length);

            var count = 0;
            foreach (var word in words)
            {
                if (IsPalidrome(word))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of palindrome words: " + count);
        }

        public static void CountPalindromeSentences(string paragraph)
        {
            var sentences = paragraph.Split(new string[] { ". " }, StringSplitOptions.None);
            Console.WriteLine("Total number of sentences: " + sentences.Length);

            var count = 0;
            foreach (var sentence in sentences)
            {
                if (IsPalidrome(Helpers.SanitizeString(sentence)))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of palindrome sentences: " + count);
        }

        private static bool IsPalidrome(string input)
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