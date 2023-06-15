namespace DND7_CSharpProgrammingExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basics:

            //Console.WriteLine("P1- Given two integers, write a method that swaps them using temporary variable");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Basic.SwapTwoNumbers(10, 20);

            // Conditional Statements:

            //Console.WriteLine("P2- Given a year as integer, write a method that checks if year is leap year");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(ConditionalStatements.LeapYear(2022));

            //Console.WriteLine("P3- Write a method that checks if given number (positive integer) contains digit 3");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(ConditionalStatements.Contains3(874365));

            // Loops:

            //Console.WriteLine("P4- Given an integer n (n>2), write a method that returns prime numbers from range [2, n]");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Loops.PrimeNumbersRange(30);

            //Console.WriteLine("P5- Write a method that draws hourglass shape");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Loops.DrawHourglass();

            //Console.WriteLine("P6- Write a method that draws parallelogram shape");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Loops.DrawParallelogram();

            //Console.WriteLine("P7- Write a method that draws Christmas tree shape");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Loops.DrawChristmasTree();

            //Console.WriteLine("P8- Given a string, write a method that returns substring from between two double hash signs (#)");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.ExtractString("##1234##"));

            //Console.WriteLine("P9- Given a string of two letters, where first one occurs before the second in the alphabet, ");
            //Console.WriteLine("write a method that returns full sequence of letters starting from first and ending at the second one");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.FullSequenceOfLetters("as"));

            Console.WriteLine("P10- Given an array of integers, write method that returns value of the longest strictly increasing sequence of numbers");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(Loops.LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 }));
        }
    }
}