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
    }
}
