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
    }
}
