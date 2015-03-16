/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/


using System;

    class Problem04MultiplicationSign
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if ( a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0");
            }
            else if (a != 0 && b != 0 && c != 00)
            {
                if (a < 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The product is negative");
                    }
                    else if (c > 0)
                    {
                        Console.WriteLine("The product is possitive");
                    }
                }
                else if ( b > 0 )
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The product is possitive");
                    }
                    else
                    {
                        Console.WriteLine("The product is negative");
                    }
                }
            }
            else if (a > 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The product is possitive");
                    }
                    else if (c > 0)
                    {
                        Console.WriteLine("The product is negative");
                    }
                }
                else if (b > 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The product is negative");
                    }
                    else
                    {
                        Console.WriteLine("The product is positive");
                    }
                }
            }
            }
        }
    }

