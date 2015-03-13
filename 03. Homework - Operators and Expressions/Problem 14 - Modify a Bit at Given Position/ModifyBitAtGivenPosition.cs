﻿/*Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v
at the position p from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value(0 or 1):");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int m;
        if (v == 1)
        {
            m = n | mask;
        }
        else
        {
            m = n ^ mask;
        }
        Console.WriteLine(m);
    }
}
