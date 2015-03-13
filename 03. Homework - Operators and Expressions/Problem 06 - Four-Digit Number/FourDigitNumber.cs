/*Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */
using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Write four-digit number:");
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        int sum = a + b + c + d;
        Console.WriteLine("Sum of the digits:"+sum);
        Console.WriteLine("The number in reversed order:{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("The last digit in the first position:{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged:{0}{1}{2}{3}", a, c, b, d);
    }
}
