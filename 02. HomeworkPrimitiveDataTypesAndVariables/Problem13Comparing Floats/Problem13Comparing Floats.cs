/*
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point
arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/



using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Insert number with several digits after the decimal mark\".\": ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insert another number with several digits after the decimal mark\".\": ");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = a - b;
            difference = Math.Abs(difference);
            if (difference<=eps)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal!");
            }
        }
    }

