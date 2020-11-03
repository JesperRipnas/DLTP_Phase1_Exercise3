using System;
using System.IO;
using System.Linq;

namespace DLTP_Phase1_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange fil att öppna: ");
            string path = Console.ReadLine();
            int rowCounter = 0;
            int charCounter = 0;
            int wordCounter = 0;
            //count rows
            var rows = File.ReadLines(path);
            foreach (var line in rows)
            {
                Console.WriteLine(line);
                rowCounter++;
            }
            // count characters
            string text = File.ReadAllText(path);
            string textWithoutSpace = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));
            charCounter = textWithoutSpace.Length;
            // count words
            string[] words = text.Split(new[] { "\r\n", "\r", "\n", " " }, StringSplitOptions.None);
            wordCounter = words.Length;
            // Output
            Console.WriteLine($"\nRows: {rowCounter}");
            Console.WriteLine($"Words: {wordCounter}");
            Console.WriteLine($"Characters: {charCounter}");

        }
    }
}
