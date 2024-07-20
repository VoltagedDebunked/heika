using System;
using System.Text.RegularExpressions;

namespace Heika
{
    public static class StringProcessor
    {
        // Function to reverse a string
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Function to count the number of words in a string
        public static int WordCount(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            var words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Function to remove all digits from a string
        public static string RemoveDigits(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return Regex.Replace(input, @"\d", string.Empty);
        }
    }
}
