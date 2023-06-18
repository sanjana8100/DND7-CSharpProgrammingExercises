using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class Strings
    {
        // P20:
        public static string MakeUppercase(string word)
        {
            int letterIndex = 0;
            string uppercaseWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z' && letterIndex % 2 == 0)
                {
                    letterIndex++;
                    uppercaseWord += (char)(word[i] - 32);
                }
                else if (word[i] != ' ')
                {
                    letterIndex++;
                    uppercaseWord += word[i];
                }
                else
                {
                    letterIndex = 0;
                    uppercaseWord += word[i];
                }
            }
            return uppercaseWord;
        }

        // P21:
        public static string MixTwoStrings(string word1, string word2)
        {
            string mixedWord = string.Empty;

            for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
            {
                if (i < word1.Length)
                {
                    mixedWord += word1[i];
                }
                if (i < word2.Length)
                {
                    mixedWord += word2[i];
                }
            }

            return mixedWord;
        }

        // P22:
        public static int NumberOfWords(string str)
        {
            int numberOfWords = 0;
            for (int i = 1; i < str.Length; i++)
            {
                numberOfWords = (char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords);
            }

            return numberOfWords + 1;
        }

        // P23:
        public static string RevertWordsOrder(string str)
        {
            string[] strArray = str.Split(' ');
            int len = strArray.Length;

            for (int i = 0; i < len / 2; i++)
            {
                string temp = strArray[i];

                if (i == 0)
                {
                    strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
                    strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);
                }
                else
                {
                    strArray[i] = strArray[len - 1 - i];
                    strArray[len - 1 - i] = temp;
                }
            }

            return string.Join(" ", strArray);
        }

        // P24:
        public static int HowManyOccurrences(string str, string subStr)
        {
            int found;
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                found = str.IndexOf(subStr, i);

                if (found > -1)
                {
                    total++;
                    i = found;
                }
            }

            return total;
        }
    }
}
