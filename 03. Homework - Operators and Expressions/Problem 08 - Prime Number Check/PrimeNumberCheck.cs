/*Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (0 < n <= 100) is prime
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 100: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (number > 0 && number <= 100)
        {
            if (number == 1)
            {
                Console.WriteLine("The number 1 is Prime!");
            }
            else
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("Is the number {0} prime? {1}!", number, isPrime);
            }
        }
        else
        {
            Console.WriteLine("You have entered invalid number!");
        }        
    }
}
