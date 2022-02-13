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
        //Method to check mobile number
        public static void CheckMobileNum(string Mobilenum)
        {
            string mobilenumpattern = @"^\+91-[6-9][0-9]{9}";
            if (Regex.IsMatch(Mobilenum, mobilenumpattern))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Invalid mobile number!!");
        }
        //Method to check password with atleast one numeric number
        public static void CheckPassword(string password)               
        {
            string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            string specialChar = "[&%$#@^*!~]";
            int count = Regex.Matches(password,specialChar).Count;
            if (Regex.IsMatch(password, passwordPattern) && count==1)
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Invalid password!!");
        }
        public static string sampleEmailPattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static void SampleEmail()
        {
            string[] sampleEmail ={"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc-100@abc.net","abc111@abc.com","abc+100@gmail.com",
                                   "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc","abc@.com.my","abc123@gmail.a","abc123@.com",
                                   "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@gmail.com.1a",
                                   "abc@gmail.com.aa.au","abc..2002@gmail.com"};

            Console.WriteLine("Validate Sample Email Id");
            Validate(sampleEmail, sampleEmailPattern);
        }
        public static void Validate(string[] arr, string pattern)
        {
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, pattern))
                    Console.WriteLine(item + " \t\t " + "Valid Email");
                else
                    Console.WriteLine(item + " \t\t " + "InValid Email");
            }
        }

    }
}