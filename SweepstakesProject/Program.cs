using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = "mike";
            Sweepstakes sweepstakes = new Sweepstakes(name);
            Contestant contestant = new Contestant();
            contestant.emailAddress = "djkfsfdsjkfs@something.com";
            contestant.firstName = "Mike";
            contestant.lastName = "Jordan";
            sweepstakes.RegisterContestant(contestant);
            Contestant contestant1 = new Contestant();
            contestant1.emailAddress = "pahoua@something.com";
            contestant1.firstName = "PaHoua";
            contestant1.lastName = "Lee";
            sweepstakes.RegisterContestant(contestant1);
            Contestant contestant2 = new Contestant();
            contestant2.emailAddress = "pahoua@something.com";
            contestant2.firstName = "Mai";
            contestant2.lastName = "Chang";
            sweepstakes.RegisterContestant(contestant2);
            string winner = sweepstakes.PickWinner();
            Console.WriteLine("1st " + winner);

            winner = sweepstakes.PickWinner();
            Console.WriteLine("2nd " + winner);
            winner = sweepstakes.PickWinner();
            Console.WriteLine("3rd " + winner);

            sweepstakes.PrintContestantInfo(contestant);
            sweepstakes.PrintContestantInfo(contestant1);
            sweepstakes.PrintContestantInfo(contestant2);

            Console.ReadLine();

            Contestant contestant3 = new Contestant();
            contestant3.firstName = UserInterface.FirstName();
            Console.ReadLine();
            contestant3.lastName = UserInterface.LastName();
            Console.ReadLine();
            contestant3.emailAddress = UserInterface.EmailAddress();
            Console.ReadLine();

            UserInterface.DisplayConstestantInfo(contestant3);

            string user = UserInterface.PickSweepstakesTypeManager(); //variable to store input of manager type
            Console.ReadLine();



        }
    }
}
