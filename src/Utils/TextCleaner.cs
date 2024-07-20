using System.Text.RegularExpressions;

namespace Heika.Utils
{
    public static class TextCleaner
    {
        // Function to remove all special characters from a string
        public static string RemoveSpecialCharacters(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return Regex.Replace(input, @"[^0-9a-zA-Z\s]", string.Empty);
        }

        // Function to normalize white spaces in a string
        public static string NormalizeWhiteSpace(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return Regex.Replace(input, @"\s+", " ").Trim();
        }
    }
}