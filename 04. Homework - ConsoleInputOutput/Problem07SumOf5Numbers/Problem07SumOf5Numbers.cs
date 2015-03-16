/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/



using System;

    class Problem07SumOf5Numbers
    {
        static void Main()
        {
            
            /*Console.Write("Insert 5 numbers separated by a space: ");
            string input = Console.ReadLine();
            string number = "";
            Console.WriteLine(number);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    number += input[i];
                    if (i == input.Length - 1)
                    {
                        sum += double.Parse(number);
                    }
                }
                else
                {
                    sum += double.Parse(number);
                    number = "";
                }
            }
            Console.WriteLine("The sum of the entered numbers is {0}", sum);*/
         
            //втори вариант

            Console.Write("Enter 5 numbers, separated by a space: ");
            string[] numbers = Console.ReadLine().Split(' ');

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                double convertedNumber = Convert.ToDouble(numbers[i]);
                sum = sum + convertedNumber;
            }
            Console.WriteLine("Sum is {0}", sum);            
            
        }
    }
