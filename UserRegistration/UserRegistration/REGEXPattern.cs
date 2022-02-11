using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class REGEXPattern
    {
        //Method to check first name
        public  static void CheckFirstName(string name)
        {
            string firstNamePattern = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(name, firstNamePattern))
            {
                Console.WriteLine("First Name is valid");
            }
            else
                Console.WriteLine("Invalid name!!");
        }
        //Method to check Lasst name
        public static void CheckLastName(string lastName)
        {
            string lastNamePattern = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lastName, lastNamePattern))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }

    }
}