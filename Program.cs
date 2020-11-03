using System;
using System.IO;

namespace DLTP_Phase1_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange fil att öppna: '\n");
            string path = @"C:\Users\rippan\Desktop\file.txt"; //Console.ReadLine();
            int rowCounter = 0;

            var textFile = File.ReadLines(path);
            foreach (var line in textFile)
            {
                Console.WriteLine(line);
                rowCounter++;
            }
            Console.WriteLine($"\nRows: {rowCounter}");
        }
    }
}
