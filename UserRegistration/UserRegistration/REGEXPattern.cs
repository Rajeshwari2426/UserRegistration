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

    }
}