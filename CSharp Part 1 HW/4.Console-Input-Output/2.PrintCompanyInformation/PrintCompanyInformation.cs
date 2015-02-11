using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

namespace _2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Web site: ");
            string companyWebSite = Console.ReadLine();
           
            Console.Write("Manager's first name: ");
            string mFirstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string mLastName = Console.ReadLine();
            Console.Write("Manager's age: ");
            string mAge = (Console.ReadLine());
            Console.Write("Manager's phone: ");
            string mPhone = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWeb site: {4}\n"
                                , companyName, companyAddress, companyPhone, companyFax, companyWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})"
                                , mFirstName, mLastName, mAge, mPhone);
        }
    }
}
