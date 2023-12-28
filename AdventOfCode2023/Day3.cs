using System;
using System.IO;

namespace AdventOfCode2023
{
    class Day3
    {
        public static void part1()
        {
            string[] lines = File.ReadAllLines("day3.txt");

            int sum = 0;

            for (int y = 0; y < lines.Length; y++)
            {
                string line = lines[y];
                int number = 0;
                bool hasSymbol = false;

                for(int x = 0; x < line.Length; ++x)
                {
                    int digit = line[x] - '0';
                    if (digit >= 0 && digit <= 9)
                    {
                        if(number == 0)
                        {
                            // start new number
                            hasSymbol |= isSymbol(lines, x - 1, y - 1);
                            hasSymbol |= isSymbol(lines, x - 1, y);
                            hasSymbol |= isSymbol(lines, x - 1, y + 1);
                        }
                        number = number * 10 + digit;
                        hasSymbol |= isSymbol(lines, x, y - 1);
                        hasSymbol |= isSymbol(lines, x, y + 1);
                    }
                    else if(number != 0)
                    {
                        //end number
                        hasSymbol |= isSymbol(lines, x, y - 1);
                        hasSymbol |= isSymbol(lines, x, y);
                        hasSymbol |= isSymbol(lines, x, y + 1);

                        if (hasSymbol)
                            sum += number;
                        number = 0;
                        hasSymbol = false;
                    }
                }

                if (hasSymbol)
                    sum += number;
            }


            Console.WriteLine(sum);
            Console.Read();
        }

        public static bool isSymbol(string[] lines, int x, int y)
        {
            if (y < 0 || y >= lines.Length)
                return false;

            string line = lines[y];

            if (x < 0 || x >= line.Length)
                return false;

            char c = line[x];
            return c != '.' && (c < '0' || c > '9');
        }
    }
}
