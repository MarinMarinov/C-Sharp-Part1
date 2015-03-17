/*Problem 2. Numbers Not Divisible by 3 and 7

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n
not divisible by 3 and 7, on a single line, separated by a space.*/

using System;

    class Program
    {
        static void Main()
        {
            //this code represents all numbers between a and b(not only 1 and n) not divisible by 3 and 7
            Console.WriteLine("Insert first nimber a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("All numbers in the interval [{0},{1}] that can be divided by 3 and 7 are:", a, b);
            for (int i = a; i <= b; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }

