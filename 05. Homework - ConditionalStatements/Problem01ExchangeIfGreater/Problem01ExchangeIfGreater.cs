/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one
is greater than the second one. As a result print the values a and b, separated by a space.*/

using System;

class Problem09PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Insert number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert number b: ");
        double b = double.Parse(Console.ReadLine());
        double c;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}

