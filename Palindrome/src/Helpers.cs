using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Helpers
    {
        public static string SanitizeString(string paragraph)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(paragraph, "").ToLower();
        }
    }
}