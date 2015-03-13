/*Problem 10. Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
 and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointInsideCircleOrRectangle
{
    static void Main()
    {
        Console.Write("enter point X:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("enter point Y:");
        double y = double.Parse(Console.ReadLine());
        bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
        bool outRect = (x <= -1 || x >= 5) || (y <= -1 || y >= 1);
        if (inCircle && outRect)
        {
            Console.WriteLine("The Point IS within the circle and out of the rectangle");
        }
        else
        {
            Console.WriteLine("The Point IS NOT within the circle and out of the rectangle");
        }
    }
}
