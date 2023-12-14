using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    class Day2
    {
        public static void part1()
        {
            string[] lines = File.ReadAllLines("day2.txt");

            int sum = 0;

            foreach (var line in lines)
            {
                var games = line.Split(':', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                int gameNumber = int.Parse(games[0].Split(' ')[1]);

                var sets = games[1].Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                foreach (var set in sets)
                {
                    int red = 0;
                    int green = 0;
                    int blue = 0;

                    var colors = set.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                    foreach(var color in colors)
                    {
                        var b = color.Split(' ');
                        var n = int.Parse(b[0]);
                        switch (b[1]) 
                        {
                            case "red":
                                red = (n > red) ? n : red; break;
                            case "green":
                                green = (n > green) ? n : green; break;
                            case "blue":
                                blue = (n > blue) ? n : blue; break;
                        }
                    }

                    if(red > 12 || green > 13 || blue > 14)
                    {
                        goto skip;
                    }
                }

                sum += gameNumber;
                skip:
                int r = 9;
            }

            Console.WriteLine(sum);
            Console.Read();
        }

        public static void part2()
        {
            string[] lines = File.ReadAllLines("day2.txt");

            int sum = 0;

            foreach (var line in lines)
            {
                var games = line.Split(':', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var sets = games[1].Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                int red = 0;
                int green = 0;
                int blue = 0;
                foreach (var set in sets)
                {
                    var colors = set.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                    foreach (var color in colors)
                    {
                        var b = color.Split(' ');
                        var n = int.Parse(b[0]);
                        switch (b[1])
                        {
                            case "red":
                                red = (n > red) ? n : red; break;
                            case "green":
                                green = (n > green) ? n : green; break;
                            case "blue":
                                blue = (n > blue) ? n : blue; break;
                        }
                    }
                }

                sum += red * green * blue;
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
