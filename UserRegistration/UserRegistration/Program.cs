using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Welcome User  for Registration");
        //    Console.WriteLine("*First letter should be capital.");
        //    Console.WriteLine("*length should be Minimum three characters.");
        //    Console.WriteLine("Enter First name :");
        //    string firstName = Console.ReadLine();
        //    REGEXPattern.CheckFirstName(firstName);

        //    Console.WriteLine("* Last name should starts with Capital and must have minimum 3 characters.");
        //    Console.WriteLine("Enter Last name :");
        //    string lastName = Console.ReadLine();
        //    REGEXPattern.CheckLastName(lastName);

        //    Console.WriteLine("Enter Email id :");
        //    string email = Console.ReadLine();
        //    REGEXPattern.CheckEmailId(email);

        //    Console.WriteLine("Enter Mobile No.(eg:+91-6589745984):");
        //    string mobileNum = Console.ReadLine();
        //    REGEXPattern.CheckMobileNum(mobileNum);

            Console.WriteLine("Enter a  password  with atleast one Capital letter:");
            string password = Console.ReadLine();
            REGEXPattern.CheckPassword(password);

            Console.ReadLine();
        }
    }
}
