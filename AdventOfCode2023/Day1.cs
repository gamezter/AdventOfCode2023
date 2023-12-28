using System;
using System.IO;

namespace AdventOfCode2023
{
    class Day1
    {
        public static void part1()
        {
            string[] lines = File.ReadAllLines("day1.txt");
            int sum = 0;

            foreach(var line in lines)
            {
                int calibrationValue = 0;
                for(int i = 0; i < line.Length; ++i)
                {
                    if(line[i] >= '0' && line[i] <= '9')
                    {
                        calibrationValue = 10 * (line[i] - '0');
                        break;
                    }
                }

                for (int i = line.Length - 1; i >= 0; --i)
                {
                    if (line[i] >= '0' && line[i] <= '9')
                    {
                        calibrationValue += line[i] - '0';
                        break;
                    }
                }
                sum += calibrationValue;
            }

            Console.WriteLine(sum);
            Console.Read();
        }

        public static void part2()
        {
            string[] lines = File.ReadAllLines("day1.txt");
            int sum = 0;

            foreach (var line in lines)
            {
                int calibrationValue = 0;
                for (int i = 0; i < line.Length; ++i)
                {
                    ReadOnlySpan<char> span = line.AsSpan(i);
                    char c = span[0];
                    if (c >= '0' && c <= '9')
                    {
                        calibrationValue = 10 * (c - '0');
                        break;
                    }
                    else
                    {
                        if (span.StartsWith("one"))
                        {
                            calibrationValue = 10;
                            break;
                        }
                        else if (span.StartsWith("two"))
                        {
                            calibrationValue = 20;
                            break;
                        }
                        else if (span.StartsWith("three"))
                        {
                            calibrationValue = 30;
                            break;
                        }
                        else if (span.StartsWith("four"))
                        {
                            calibrationValue = 40;
                            break;
                        }
                        else if (span.StartsWith("five"))
                        {
                            calibrationValue = 50;
                            break;
                        }
                        else if (span.StartsWith("six"))
                        {
                            calibrationValue = 60;
                            break;
                        }
                        else if (span.StartsWith("seven"))
                        {
                            calibrationValue = 70;
                            break;
                        }
                        else if (span.StartsWith("eight"))
                        {
                            calibrationValue = 80;
                            break;
                        }
                        else if (span.StartsWith("nine"))
                        {
                            calibrationValue = 90;
                            break;
                        }
                    }
                }

                for (int i = 0; i < line.Length; ++i)
                {
                    ReadOnlySpan<char> span = line.AsSpan(0, line.Length - i);
                    char c = span[span.Length - 1];
                    if (c >= '0' && c <= '9')
                    {
                        calibrationValue += c - '0';
                        break;
                    }
                    else
                    {
                        if (span.EndsWith("one"))
                        {
                            calibrationValue += 1;
                            break;
                        }
                        else if (span.EndsWith("two"))
                        {
                            calibrationValue += 2;
                            break;
                        }
                        else if (span.EndsWith("three"))
                        {
                            calibrationValue += 3;
                            break;
                        }
                        else if (span.EndsWith("four"))
                        {
                            calibrationValue += 4;
                            break;
                        }
                        else if (span.EndsWith("five"))
                        {
                            calibrationValue += 5;
                            break;
                        }
                        else if (span.EndsWith("six"))
                        {
                            calibrationValue += 6;
                            break;
                        }
                        else if (span.EndsWith("seven"))
                        {
                            calibrationValue += 7;
                            break;
                        }
                        else if (span.EndsWith("eight"))
                        {
                            calibrationValue += 8;
                            break;
                        }
                        else if (span.EndsWith("nine"))
                        {
                            calibrationValue += 9;
                            break;
                        }
                    }
                }
                sum += calibrationValue;
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
