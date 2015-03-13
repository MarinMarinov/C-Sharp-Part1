/*Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
 in given integer number n, has value of 1.
 */

using System;

    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter the index p of the bit: ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int maskAndN = mask & n;
            int bit = maskAndN >> p;
            Console.WriteLine(bit == 1 ? true : false);
        }
        
    }
