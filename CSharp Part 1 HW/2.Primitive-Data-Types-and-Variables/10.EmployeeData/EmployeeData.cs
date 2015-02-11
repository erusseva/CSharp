using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
  // First name
  // Last name
  // Age (0...100)
  // Gender (m or f)
  // Personal ID number (e.g. 8306112507)
  // Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "FirstName";
            string lastName = "LastName";
            byte age = 26;
            string gender = "Female";
            ulong id = 8306112507;
            int uniqueEmployeeNumber = 27560333;

            Console.WriteLine("First name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}",
                              firstName, lastName, age, gender, id, uniqueEmployeeNumber);
        }
    }
}
