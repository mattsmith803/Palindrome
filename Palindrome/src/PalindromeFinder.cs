using System;

namespace Palindrome
{
    public class PalindromeFinder
    {
        public static void ExecuteCountPalindromeWords(string paragraph)
        {
            var count = CountPalindromeWords(paragraph);
            Console.WriteLine("Number of palindrome words: " + count);
        }

        public static int CountPalindromeWords(string paragraph)
        {
            if (paragraph == "")
            {
                return 0;
            }

            var words = paragraph.Split(' ');

            var count = 0;
            foreach (var word in words)
            {
                if (IsPalidrome(Helpers.SanitizeString(word)))
                {
                    count++;
                }
            }

            return count;
        }

        public static void ExecuteCountPalindromeSentences(string paragraph)
        {
            var count = CountPalindromeSentences(paragraph);
            Console.WriteLine("Number of palindrome sentences: " + count);
        }

        public static int CountPalindromeSentences(string paragraph)
        {
            if (paragraph == "")
            {
                return 0;
            }

            var sentences = paragraph.Split(new string[] { ". " }, StringSplitOptions.None);

            var count = 0;
            foreach (var sentence in sentences)
            {
                if (IsPalidrome(Helpers.SanitizeString(sentence)))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsPalidrome(string input)
        {
            if (input == "")
            {
                return false;
            }


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