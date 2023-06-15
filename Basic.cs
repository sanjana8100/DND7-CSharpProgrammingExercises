using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND7_CSharpProgrammingExercises
{
    internal class Basic
    {
        public static void SwapTwoNumbers(int number1, int number2)
        {
            Console.WriteLine("The original value of the numbers: ");
            Console.WriteLine($"Number1: {number1} and Number2: {number2}");

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("The numbers after swapping: ");
            Console.WriteLine($"Number1: {number1} and Number2: {number2}");
        }
    }
}
