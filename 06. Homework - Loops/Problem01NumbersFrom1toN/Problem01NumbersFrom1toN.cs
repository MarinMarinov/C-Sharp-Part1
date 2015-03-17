/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
on a single line, separated by a space*/
//Note: The code also gives us the sum!!!!!!!

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert number n=?");
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            Console.WriteLine("The numbers in the sequence are:");
            while (number < n)
            {                
                number++;
                sum += number;
                Console.Write("{0} ", number);                
            }
            Console.WriteLine();

            Console.WriteLine("The sum is:" + sum);
        }
    }

