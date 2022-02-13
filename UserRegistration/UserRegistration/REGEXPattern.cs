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
        //Method to check Last name
        public static void CheckLastName(string lastName)
        {
            string lastNamePattern = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lastName, lastNamePattern))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
        //Method to check email
        public static void CheckEmailId(string Emailid)
        {            
            string emailpattern = "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            if (Regex.IsMatch(Emailid, emailpattern))
                Console.WriteLine("Email id is valid");
            else
                Console.WriteLine("Invalid email id!!");
        }
        public static void CheckMobileNum(string Mobilenum)
        {
            string mobilenumpattern = @"^\+91-[6-9][0-9]{9}";
            if (Regex.IsMatch(Mobilenum, mobilenumpattern))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Invalid mobile number!!");
        }

    }
}