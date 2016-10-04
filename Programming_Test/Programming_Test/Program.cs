using System;
using System.Linq;

namespace Programming_Test
{
    public class Program
    {
        private static void Main()
        {
            string sentence = "This is a statement, and so is this";

            foreach (var word in sentence.Split(new[] {'.', '?', '!', ' ', ';', ':', ','},
                    StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(g => g.ToLowerInvariant())
                .Select(g => new {Word = g.Key, count = g.Count()}))
                Console.WriteLine($"{word.Word} - {word.count}");
            Console.ReadKey();
        }
    }
}
