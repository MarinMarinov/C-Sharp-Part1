/*Problem 12. Null Values Arithmetic
        Create a program that assigns null values to an integer and to a double variable.
        Try to print these variables at the console.
        Try to add some number or the null literal to these variables and print the result.*/

using System;
        

namespace Problem12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? first = null;
            double? second = null;

            Console.WriteLine("First: {0}, Second: {1}", first, second);
            Console.WriteLine("Adding values 3 and 4!");
            first = 3;
            second = 4;
            Console.WriteLine("First: {0}, Second: {1}", first, second);
        }
    }
}
