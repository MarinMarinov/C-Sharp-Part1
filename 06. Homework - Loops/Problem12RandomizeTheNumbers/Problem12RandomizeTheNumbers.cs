/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

using System;
using System.Collections.Generic;

class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        Random randomFunction = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers.Add(i + 1);
        }

        while (numbers.Count > 0)
        {
            int randomNumber = randomFunction.Next(0, numbers.Count); // извеждаме произволно число в интервала 0 до n
            Console.Write(numbers[randomNumber]); // изписваме произволното число
            if (numbers.Count > 1)
            {
                Console.Write(' '); // изписваме интервали, докато има останали числа в сiпсъка numbers
            }
            numbers.RemoveAt(randomNumber); //махаме това число от списъка
        }
        Console.WriteLine();
    }
}
