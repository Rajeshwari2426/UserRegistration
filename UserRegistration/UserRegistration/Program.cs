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
            Console.WriteLine("Welcome User  for Registration");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string firstName = Console.ReadLine();     
            REGEXPattern.CheckFirstName(firstName);
            Console.ReadLine();
        }
    }
}
