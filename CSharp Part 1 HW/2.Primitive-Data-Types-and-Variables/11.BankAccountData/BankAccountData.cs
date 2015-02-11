using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "FirstName";
            string middleName = "MiddleName";
            string lastName = "LastName";
            double balance = 12345678.99;
            string bankName = "BankName AD";
            string IBAN = "BG44CECB979010C9727999";
            string BIC = "CECBBGSF";
            string creditCard1 = "3402556217809447";
            string creditCard2 = "3402556217809446";
            string creditCard3 = "3402556217809445";

            Console.WriteLine("Bank Account Data: \nFull name: {0} {1} {2}",
                                firstName, middleName, lastName);
            Console.WriteLine("Balance: {0}\nBank: {1}", 
                                balance, bankName);
            Console.WriteLine("IBAN: {0}, BIC: {1}", 
                                IBAN, BIC);
            Console.WriteLine("Credit card 1: {0}\nCredit card 2: {1}\nCredit card 3: {2}", 
                                creditCard1, creditCard2, creditCard3);
        }
    }
}
