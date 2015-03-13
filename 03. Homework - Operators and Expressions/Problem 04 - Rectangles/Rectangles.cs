/*Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("This program calculates the perimeter and area of a rectangle");
        Console.Write("Enter a and b (for width and height) : ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        double area = (double)(a * b);
        double perimeter = (double)(a + b) * 2;
        Console.WriteLine("The area is {0}\nThe perimeter is {1}", area,perimeter);
    }
}
