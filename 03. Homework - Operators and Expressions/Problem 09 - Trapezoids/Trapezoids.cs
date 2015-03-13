using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("This program calculates the area of a trapezoid. You must enter a and b for the sides and h for the height.");
        Console.WriteLine("Enter a, b and h in that order: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (double)(a + b)*h / 2;
        Console.WriteLine("The area is {0}\n", area);
    }
}
