/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.*/

using System;

    class Problem10FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;

            if (n == 1)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write(a + ", " + b);

                for (int i = 0; i < n - 2; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;

                    Console.Write(", " + sum);
                }

                Console.WriteLine();
            }
        }
    }

