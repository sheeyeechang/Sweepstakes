using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {    
        //member variable (HAS A)

        //constructor

        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(10 points) I want to create a user interface for any information the application 
        //would need to get from the user. One example would be the functionality to assign a Contestant object a 
        //first name, last name, email address, and registration number.

        public static string AskFirstName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToString();
            return firstName;
        }
        public static string AskLastName()
        {
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine().ToString();
            return lastName;
        }
        public static string AskEmail()
        {
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine().ToString();
            return email;

        }
        public static int AskRegistrationNumber()
        {
            Console.WriteLine("What is your registratio number?");
            int registrationNumber = Int32.Parse(Console.ReadLine());
            return registrationNumber;
        }
        public static void DisplayConstestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: " + contestant.firstName);
            Console.WriteLine($"Last Name: " + contestant.lastName);
            Console.WriteLine($"Email: " + contestant.emailAddress);
            Console.WriteLine($"Registration Number: " + contestant.registrationNumber);
        }
        
        
    }
}
