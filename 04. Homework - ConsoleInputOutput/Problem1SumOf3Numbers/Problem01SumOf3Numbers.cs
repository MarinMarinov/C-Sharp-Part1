/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/


using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, insert the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double sum = (firstNumber + secondNumber + thirdNumber);
            Console.WriteLine("The sum of these numbers is: " + sum);
        }
    }

