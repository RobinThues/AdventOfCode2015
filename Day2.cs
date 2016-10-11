using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdventOfCode2015Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = 0, ribbon = 0;
            int lwNeeds, whNeeds, hlNeeds;
            int[] sideSizes;
            string[] inputLines;
            string path = @"C:\Users\robin\OneDrive\AoC\input2.txt";
            inputLines = File.ReadAllLines(path);
            foreach(string line in inputLines)
            {
                sideSizes = Array.ConvertAll(line.Split(new char[] {'x'}), int.Parse); // split l w h
                lwNeeds = 2 * sideSizes[0] * sideSizes[1]; // 2*l*w
                whNeeds = 2 * sideSizes[1] * sideSizes[2]; // 2*w*h
                hlNeeds = 2 * sideSizes[2] * sideSizes[0]; // 2*h*l
                order += lwNeeds+whNeeds+hlNeeds+new int[]{lwNeeds/2, whNeeds/2, hlNeeds/2}.Min(); // extra

                ribbon += sideSizes[0] * sideSizes[1] * sideSizes[2]; // bow
                IEnumerable<int> orderedSides = sideSizes.OrderBy(num => num); // order sides by size
                ribbon += 2 * orderedSides.ElementAt(0) + 2 * orderedSides.ElementAt(1); // use the two smallest sides
            }
            Console.WriteLine("wrapping paper neede:" + order);
            Console.WriteLine("ribbon needed:" + ribbon);
            Console.ReadLine();
        }
    }
}
