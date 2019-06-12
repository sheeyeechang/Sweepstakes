using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class UserInterface
    {        //member variable (HAS A)

        //constructor
        public UserInterface()
        {

        }
        //method (CAN DO)  -------------------------------------------------------

        public static string AskFirstName()
        {
            Console.WriteLine("What is your first name?");
        }
        public static string AskLastName()
        {
            Console.WriteLine("What is your last name?");
        }
        public static string AskEmail()
        {
            Console.WriteLine("What is your email?");

        }
        public static int AskRegistrationNumber()
        {
            Console.WriteLine("What is your registratio number?");

        }
        public static void DisplayConstestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: " + contestant.firstName);
            Console.WriteLine($"Last Name: " + contestant.lastName);
            Console.WriteLine($"Email: " + contestant.email);
            Console.WriteLine($"Registration Number: " + contestant.registrationNumber);
        }
        
        
    }
}
