/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/ 

using System;

class Program
{
    static void Main()
    {        
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Now.Year - birthday.Year;
        //long result = DateTime.Today.Subtract(birthday).Ticks;
        Console.WriteLine("You are {0} years old.", age);
        int ageAfterTenYears = age + 10;
        Console.WriteLine("After 10 years You will be {0} years old.", ageAfterTenYears);
    }
}
