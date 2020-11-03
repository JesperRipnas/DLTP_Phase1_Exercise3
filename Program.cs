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

            var rows = File.ReadLines(path);
            foreach (var line in rows)
            {
                Console.WriteLine(line);
                rowCounter++;
            }

            string text = File.ReadAllText(path);
            string textWithoutSpace = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));
            charCounter = textWithoutSpace.Length;

            Console.WriteLine($"\nRows: {rowCounter}");
            Console.WriteLine($"Characters: {charCounter}");
        }
    }
}
