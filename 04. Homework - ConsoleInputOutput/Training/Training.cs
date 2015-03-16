using System;

    class Training
    {
        static void Main()
        {
            /*Problem 10. Fibonacci Numbers

            Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
            (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

            /*Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum = sum + a;
                a = b;
                b = sum;                
                Console.WriteLine(sum);
            }*/



            /*Problem 7. Sum of 5 Numbers

            Write a program that enters 5 numbers (given in a single line, separated by a space),
            calculates and prints their sum.*/

            /*Console.WriteLine("Insert 5 numbers separated by space: ");
            string[] input = Console.ReadLine().Split(' ');
            
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Convert.ToInt32(input[i]);             
            }
            Console.WriteLine(sum);*/

            int a = int.Parse(Console.ReadLine());
            string binaryA = Convert.ToString(a, 16);
            Console.WriteLine(binaryA);




        }
    }

