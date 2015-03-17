/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert how many numbers will be printed");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert minimal value");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert maximal value");
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
    }
}

