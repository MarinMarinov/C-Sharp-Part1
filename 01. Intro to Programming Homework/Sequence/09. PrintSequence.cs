/*Problem 9. Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

using System;

class Program
{
    static void Main()
    {
        int a = 1;
        int counter = 2;
        for (int i = 2; i <= 10; i++)
        {
            if (counter % 2 == 0)
            {
                a = a * i; 
            }
            else if (counter % 2 != 0)
            {
                a = a * i * (-1);
            }           
            Console.Write(a + ", ");
            counter++;
            a = 1;
        }
        Console.WriteLine();       
    }
}
    
