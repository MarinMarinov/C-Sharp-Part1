/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The number starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert how many numbers will be the sequence");
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxValue = int.MinValue; // инициализираме maxValue = -2147483648, т.е. с най-малката възможна стойност
            int minValue = int.MaxValue; // инициализираме minValue = 2147483648

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the {0} number", i);
                int number = int.Parse(Console.ReadLine());

                sum += number;
                if (number > maxValue)
                {
                    maxValue = number; //приравняваме maxValue на по-високата стойност на number
                }
                if (number < minValue)
                {
                    minValue = number; //приравняваме minValue на по-ниската стойност на number
                }
            }
            double average = (double)sum / (double)count;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3 :F2}", minValue, maxValue, sum, average);            
        }
    }

