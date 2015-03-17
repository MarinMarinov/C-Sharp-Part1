/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop*/


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert value of N > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert value of K < N < 100");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        Console.WriteLine("N!/K! = {0}", result);
    }
}

