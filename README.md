# Heika
Heika is a C# String manipulation library for easily working with strings, boolean algebra, and other.
## Features
Heika offers features like:
- String manipulation
- Dirty text
- Reverse string
- Special Character Removal
- Word counter
- Remove digits from string
# Usage
First, copy the repository:
```bash
git clone https://github.com/voltageddebunked/heika
```
Then, navigate to the files:
```bash
cd heika/src
```
And create a new file.
```bash
touch program.cs
```
Here's a simple example file:
```csharp
using System;
using Heika;
using Heika.Utils;

namespace HeikaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World! 123";

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {StringProcessor.Reverse(text)}");
            Console.WriteLine($"Word Count: {StringProcessor.WordCount(text)}");
            Console.WriteLine($"Without Digits: {StringProcessor.RemoveDigits(text)}");

            string dirtyText = "  Hello,    World!    123   ";
            Console.WriteLine($"Original: {dirtyText}");
            Console.WriteLine($"Cleaned: {TextCleaner.RemoveSpecialCharacters(dirtyText)}");
            Console.WriteLine($"Normalized: {TextCleaner.NormalizeWhiteSpace(dirtyText)}");
        }
    }
}
```
## License
This project is licensed under the `Apache 2.0` license. See the [LICENSE](LICENSE) file for details.
