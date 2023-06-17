﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class Loops
    {
        // P4: 
        public static void PrimeNumbersRange(int range)
        {
            Console.WriteLine($"The Prime Numbers Between the range 2 to {range} are:");
            for (int number = 2; number <= range; number++)
            {
                int count = 0;
                for (int index = 2; index <= number / 2; index++)
                {
                    if (number % index == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && number != 1)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        // P5: 
        public static void DrawHourglass()
        {
            for (var i = 0; i <= 10; i++)
            {
                for (var j = 0; j < (i <= 5 ? i : 10 - i); j++)
                {
                    Console.Write(" ");
                }
                for (var k = i <= 5 ? i : 10 - i; k <= (i <= 5 ? 10 - i : i); k++)
                {
                    Console.Write("*");
                }
                for (var m = 10 - i; m < 10; m++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        // P6: 
        public static void DrawParallelogram()
        {
            for (var j = 0; j < 5; j++)
            {
                for (var k = 0; k < 5 - j; k++)
                {
                    Console.Write(" ");
                }
                for (var m = 0; m < 15; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // P7: 
        public static void DrawChristmasTree()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 7; j += 2)
                {
                    for (var k = 0; k < (7 - j) / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    for (var m = 0; m <= j; m++)
                    {
                        Console.Write("*");
                    }
                    for (var n = (7 - j) / 2; n < 7; n++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // P8: 
        public static string ExtractString(string word)
        {
            string extractedWord = string.Empty;
            bool firstOccurrence = false;
            bool secondOccurrence = false;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] == '#' && word[i + 1] == '#')
                {
                    firstOccurrence = true;
                    for (int j = i + 2; j <= word.Length - 1; j++)
                    {
                        if (word[j] == '#' && word[j + 1] == '#')
                        {
                            secondOccurrence = true;
                            return extractedWord;
                        }
                        extractedWord += word[j];
                    }
                }
            }
            return string.Empty;
        }

        // P9: 
        public static string FullSequenceOfLetters(string word)
        {
            string fullSequence = string.Empty;
            for (int i = word[0], j = 0; i <= word[1]; i++, j++)
            {
                fullSequence += (char)(word[0] + j);
            }
            return fullSequence;
        }

        // P10: 
        public static int LongestStrictlyIncreasingSequence(int[] array)
        {
            int tempLongest = 0;
            int longest = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] > array[i])
                {
                    tempLongest++;
                }
                else
                {
                    tempLongest = 0;
                }

                if (tempLongest > longest)
                {
                    longest = tempLongest;
                }
            }
            return longest;
        }

        // P11: 
        public static int BitsToNumber(string bits)
        {
            var number = 0;

            for (var i = 0; i < bits.Length; i++)
            {
                number += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i - 1));
            }

            return number;
        }
    }
}
