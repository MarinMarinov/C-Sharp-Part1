/*Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */
using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        bool check = (input / 100) % 10 == 7;
        Console.WriteLine("Is the third digit of {0} (right-to-left) 7? {1}!", input, check);
    }
}
