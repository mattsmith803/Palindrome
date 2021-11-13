namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindrome!");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Type 'exit' or 'e' to exit");
                Console.WriteLine();

                Console.Write("Enter a paragraph or file path: ");
                Console.WriteLine();

                string input = Console.ReadLine() ?? "";
                Console.WriteLine();

                if (input.ToLower() == "exit" || input.ToLower() == "e")
                {
                    Console.WriteLine("Bye!");
                    return;
                }

                if (File.Exists(input))
                {
                    input = File.ReadAllText(input);
                }

                PalindromeFinder.ExecuteCountPalindromeSentences(input);
                PalindromeFinder.ExecuteCountPalindromeWords(input);
                UniqueWords.ExecuteUniqueWords(input);

                Console.WriteLine();
            }
        }
    }
}