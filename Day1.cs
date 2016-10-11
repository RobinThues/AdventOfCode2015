using System;
using System.IO;

namespace AdventOfCode2015Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string path = @"C:\Users\robin\OneDrive\AoC\input.txt";
            int floor = 0, position = 0, basementEnteredAt = 0;
            bool found = false;   
            text = File.ReadAllText(path);
            foreach(char c in text)
            {
                if (c == '(')
                    floor++;
                else
                    floor--;
                position++;
                if (floor == -1 && found == false)
                {
                    basementEnteredAt = position;
                    found = true;
                }
            }
            Console.WriteLine("part 1:" + floor);
            Console.WriteLine("part 2:" + basementEnteredAt);
            Console.ReadLine();
        }
    }
}
