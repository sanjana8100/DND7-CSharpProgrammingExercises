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

            //Console.WriteLine("P10- Given an array of integers, write method that returns value of the longest strictly increasing sequence of numbers");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 }));

            //Console.WriteLine("P11- Write a method that takes non-empty string of bits as an argument and returns number as integer");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.BitsToNumber("100100"));

            //Console.WriteLine("P12- Given a non-negative number, write a method that returns sum of its digits");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.DigitsSum(452));

            //Console.WriteLine("P13- Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m]");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.SumAndAverage(11, 40));

            //Console.WriteLine("P14- Given an array of objects, write a method that returns sum of objects of double type");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.SumDoubleOnly(new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true }));

            //Console.WriteLine("P15- Write a method that draws triangle shape");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Loops.DrawTriangle();

            //Console.WriteLine("P16- Given two integers, write a method that returns first number raised to the power of second one");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.ToThePowerOf(10, 0));

            //Console.WriteLine("P17- Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string.");
            //Console.WriteLine("Assume string length is even and letters don't repeat on each side");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.LettersBalance("kfdfdk"));

            //Console.WriteLine("P18- Given a string in which two words are separated by a char, write a method that replaces these two words");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.ReplaceWords("Good_Morning", '_'));

            //Console.WriteLine("P19- Given a non-negative number, write a method that returns its digital root");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Loops.DigitalRoot(5));

            // Strings:

            //Console.WriteLine("P20- Given a string, write a method that returns new string in which every odd letter of the word is uppercase");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Strings.MakeUppercase("Have a Happy Morning"));

            //Console.WriteLine("P21- Given two strings, write a method that returns one string made of two strings");
            //Console.WriteLine("----------------------------------------------------------------------------------");
            //Console.WriteLine(Strings.MixTwoStrings("APPLE", "MANGO"));

            Console.WriteLine("P22- Given a string, write a method that counts its number of words");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(Strings.NumberOfWords("All The Very Best"));
        }
    }
}