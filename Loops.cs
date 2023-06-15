using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class Loops
    {
        public static void PrimeNumbersRange(int range)
        {
            Console.WriteLine($"The Prime Numbers Between the range 2 to {range} are:");
            for (int number = 2; number <= range; number++)
            {
                int count = 0;
                for (int index = 2; index <= number/2; index++)
                {
                    if(number % index == 0)
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
    }
}
