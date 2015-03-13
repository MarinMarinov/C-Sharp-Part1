/*Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write( "Enter the coordinates X and Y:");
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        int radius = 2;
        bool answer = ((pointX * pointX) + (pointY * pointY)) <= radius * radius;
        Console.WriteLine("The point is in the circle--> "+answer);
    }
}
