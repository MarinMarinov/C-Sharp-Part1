/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
Note: You may need to use a for-loop.*/

using System;

    class Problem09SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Write a positive integer number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Write a number: ");
                int a = int.Parse(Console.ReadLine());
                sum += a;
            }

            Console.WriteLine(sum);
        }
    }

