/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area
formatted with 2 digits after the decimal point.*/

using System;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert circle radius \"R\":");
            double radius = double.Parse(Console.ReadLine());
            double area = (radius * radius) * Math.PI;
            double perimeter = (Math.PI * radius) * 2;
            Console.WriteLine("Circle area is {0}\nCircle perimeter is {1}", Math.Round(area, 2), Math.Round(perimeter, 2));
        }
    }

