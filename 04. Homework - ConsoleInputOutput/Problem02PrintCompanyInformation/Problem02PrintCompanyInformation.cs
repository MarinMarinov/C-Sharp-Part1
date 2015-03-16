/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/


using System;

    class Problem02PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Insert company name");
            string nameCompany = Console.ReadLine();
            Console.WriteLine("Insert company address");
            string addresCompany = Console.ReadLine();
            Console.WriteLine("Insert phone number");
            string phoneNum = Console.ReadLine();
            Console.WriteLine("Insert fax number");
            string faxNum = Console.ReadLine();
            Console.WriteLine("Insert web side");
            string webSide = Console.ReadLine();
            Console.WriteLine("Insert first name of Manager");
            string firstName = Console.ReadLine();
            Console.WriteLine("Insert last name of Manager");
            string lastName = Console.ReadLine();
            Console.WriteLine("Insert age of Manager");
            string ageManager = Console.ReadLine();
            Console.WriteLine("Insert phone of Manager");
            string phoneManager = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(nameCompany);
            Console.WriteLine("Address:" + addresCompany);
            Console.WriteLine("Tel:" + phoneNum);
            Console.WriteLine("Fax:" + faxNum);
            Console.WriteLine("Web side: http://" + webSide);
            Console.WriteLine("Manager: {0} {1} (Age: {2}, Tel: {3})", firstName, lastName, ageManager, phoneManager);
        }
    }

