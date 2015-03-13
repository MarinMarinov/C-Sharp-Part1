/*Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
 */

using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Write a number:");
            string s = Console.ReadLine();
            int number = int.Parse(s);
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }
