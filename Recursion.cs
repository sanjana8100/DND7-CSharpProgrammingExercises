using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class Recursion
    {
        // P27:
        public static string StringInReverseOrderRecursion(string str)
        {
            return str.Length > 0 ? str[str.Length - 1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
        }

        // P28:
        public static bool IsPalindromeRecursion(string str)
        {
            if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
            {
                return true;
            }
            else if (str.Length > 1)
            {
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }

                return IsPalindromeRecursion(str.Substring(1, str.Length - 2));
            }

            return false;
        }

        // P29:
        public static int MinimumElement(int[] arr, int size)
        {
            if (size == 1)
            {
                return arr[0];
            }

            return arr[size - 1] < MinimumElement(arr, size - 1) ? arr[size - 1] : MinimumElement(arr, size - 1);
        }

    }
}
