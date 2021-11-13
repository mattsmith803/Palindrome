using System;
using System.IO;

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

                string paragraph = Console.ReadLine() ?? "";
                Console.WriteLine();

                if (paragraph.ToLower() == "exit" || paragraph.ToLower() == "e")
                {
                    Console.WriteLine("Bye!");
                    return;
                }

                if (File.Exists(paragraph))
                {
                    paragraph = File.ReadAllText(paragraph);
                }

                var analyze = true;
                while (analyze)
                {
                    Console.WriteLine("Select an action by entering the number of the action: ");
                    Console.WriteLine("\t[1] Get number of palindrome words");
                    Console.WriteLine("\t[2] Get number of palindrome sentences");
                    Console.WriteLine("\t[3] Get number of unique words and counts");
                    Console.WriteLine("\t[4] Find words with letter");
                    Console.WriteLine("\t[5] Enter new paragraph");
                    Console.WriteLine("\t[6] Exit program");
                    Console.WriteLine();

                    string action = Console.ReadLine() ?? "";
                    Console.WriteLine();

                    if (!int.TryParse(action, out int result))
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine();

                        continue;
                    }

                    switch (result)
                    {
                        case 1:
                            PalindromeFinder.ExecuteCountPalindromeWords(paragraph);
                            Console.WriteLine();
                            break;
                        case 2:
                            PalindromeFinder.ExecuteCountPalindromeSentences(paragraph);
                            Console.WriteLine();
                            break;
                        case 3:
                            WordFinder.ExecuteFindUniqueWords(paragraph);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.Write("Enter letter: ");
                            Console.WriteLine();
                            var letter = Console.ReadLine() ?? "";
                            WordFinder.ExecuteFindWordsWithLetter(paragraph, letter);
                            break;
                        case 5:
                            analyze = false;
                            break;
                        case 6:
                            Console.WriteLine("Bye!");
                            return;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                            break;
                    }
                }
            }
        }
    }
}