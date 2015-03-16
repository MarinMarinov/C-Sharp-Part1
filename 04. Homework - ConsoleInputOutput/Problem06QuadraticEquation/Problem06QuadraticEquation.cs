/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation
ax^2 + bx + c = 0 and solves it (prints its real roots).*/

using System;


    class Problem06QuadraticEquation
    {
        static void Main()
        {
            //D = b^2 – 4ac
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
            }
            
        }
    }

