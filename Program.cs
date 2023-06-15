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

            Console.WriteLine("P4- Given an integer n (n>2), write a method that returns prime numbers from range [2, n]");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Loops.PrimeNumbersRange(30);
        }
    }
}