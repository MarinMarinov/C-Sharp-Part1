/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements*/

using System;

    class Problem03CirclePerimeterandArea
    {
        static void Main()
        {
            Console.WriteLine("Insert two different numbers:");
            Console.WriteLine("The bigger one is: " + Math.Max(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));                     
        }
    }

