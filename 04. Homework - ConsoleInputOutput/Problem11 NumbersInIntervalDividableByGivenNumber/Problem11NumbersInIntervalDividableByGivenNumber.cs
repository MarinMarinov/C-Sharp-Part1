/* не е задължителна
Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
such that the reminder of the division by 5 is 0.*/

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert M: ");
            int m = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = n; i <= m; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine(i);
                    counter++; 
                }                              
            }
            Console.WriteLine(counter);

        }
    }

