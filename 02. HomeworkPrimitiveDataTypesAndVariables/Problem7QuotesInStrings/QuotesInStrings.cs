/*Problem 7. Quotes in Strings
Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/

using System;


namespace Problem7QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string stringOne = "The \"use\" of quotations ";
            string stringTwo = "causes difficulties.";
            string stringThree = "The \"use\"" + " of quotations ";
            string stringFour = "causes difficulties.";
            Console.WriteLine(stringOne + stringTwo);
            Console.WriteLine("{0}{1}", stringThree, stringFour);
        }
    }
}
