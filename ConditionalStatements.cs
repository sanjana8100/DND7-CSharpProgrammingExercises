using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class ConditionalStatements
    {
        public static bool LeapYear(int year)
        {
            Console.WriteLine($"Is {year} a Leap Year? ");
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        public static bool Contains3(int number)
        {
            Console.WriteLine($"Does {number} contain 3? ");
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
