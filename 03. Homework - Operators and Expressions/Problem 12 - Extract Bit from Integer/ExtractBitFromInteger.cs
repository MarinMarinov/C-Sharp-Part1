/*Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
 */

using System;

class ExtractBitFromInteger
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
        Console.WriteLine("The bit #{0} is: {1}", p, bit);
    }
}
