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

        public static string FirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine().ToString();           // assign operator y = x+1
            return firstName;
        }
        public static string LastName()
        {
            Console.WriteLine("Please enter your last name?");
            string lastName = Console.ReadLine().ToString();
            return lastName;
        }
        public static string EmailAddress()
        {
            Console.WriteLine("Please enter your email?");
            string emailAddress = Console.ReadLine().ToString();
            return emailAddress;
        }

        public static void DisplayConstestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}");
            Console.WriteLine($"Last Name: {contestant.lastName}");
            Console.WriteLine($"Email: {contestant.emailAddress}");
            Console.WriteLine($"Registration Number: {contestant.registrationNumber}");
            Console.ReadLine();
        }

        //ask to pick a stack or queue
        public static string PickSweepstakesTypeManager()
        {
            Console.WriteLine("Do you want your sweepstakes manage by: stack or queue?");
            string userChoice = Console.ReadLine().ToString();
            if (userChoice != "stack" || userChoice != "queue")
            {
                Console.WriteLine("Please enter: stack or queue");
                Console.ReadLine().ToString();
            }
            return userChoice;
        }


    }
}
