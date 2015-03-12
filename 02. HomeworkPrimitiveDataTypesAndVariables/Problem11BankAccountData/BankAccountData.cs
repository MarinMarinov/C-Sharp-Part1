/*Problem 11. Bank Account Data
            A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
            bank name, IBAN, 3 credit card numbers associated with the account.
            Declare the variables needed to keep the information for a single bank account using the appropriate data types
            and descriptive names.*/
using System;
            

namespace Problem11BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Marin";
            string middleName = "Rumenov";
            string lastName = "Marinov";
            object holderName = firstName + " " + middleName + " " + lastName;
            decimal accountBalance = 1234.56m;
            string bankName = "KTB";
            string iban = "BG13BGSF123456789";
            string bic = "KORPBGSF";
            ulong creditCardNumber1 = 123456789101112u;
            ulong creditCardNumber2 = 345698282897254u;
            ulong creditCardNumber3 = 687289728284842u;
            Console.WriteLine("Account holder: " + holderName
                + "\nBalance: " + accountBalance
                + " BGN\nBank: " + bankName
                + "\nIBAN: " + iban
                + "\nBIC: " + bic
                + "\nCredit Card 1: " + creditCardNumber1
                + "\nCredit Card 2: " + creditCardNumber2
                + "\nCredit Card 3: " + creditCardNumber3);
        }
    }
}
