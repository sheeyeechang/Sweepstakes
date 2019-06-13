using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //member variable (HAS A)

        public Dictionary<int, Contestant> contestantsDictionary;
        public string name;
        public Contestant winner;

        Random random;

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestantsDictionary = new Dictionary<int, Contestant>();
            random = new Random();
        }
        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(15 points) As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure 
        //as an underlying structure to hold Contestants.The Sweepstakes class will have the following methods with 
        //full implementation(write the functionality) of each method:
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestantsDictionary.Count + 1;            //do the count first before assign registration number
            contestantsDictionary.Add(contestant.registrationNumber, contestant);
        }
        // random select winner from dictionary
        public string PickWinner()
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;            // assign operator; ex. y = x+1
            winner = contestantsDictionary[winnerContestant];                           // pick value winner in dictionary same as below
           // contestantsDictionary.TryGetValue(winnerContestant, out winner);            // TryGetValue to pick winner
            string name = "First Name: " + winner.firstName + "   Last Name: " + winner.lastName + "   Registration Number: " + winner.registrationNumber;
            return name;

            //    TValue value;
            //    // attempt to get the value of the key from the dictionary
            //    dictionary.TryGetValue(key, out value);
            //    return value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}");
            Console.WriteLine($"Last Name: {contestant.lastName}");
            Console.WriteLine($"Email: {contestant.emailAddress}");
            Console.WriteLine($"Registration Number: {contestant.registrationNumber}");
            Console.ReadLine();
        }

        // ----------------------------------Extra credit  --------------------------------------------------------------
        //(5 points) As a developer, I want to use the observer design pattern to notify all users of the 
        //winning contestant, with the winner of the sweepstakes getting a different message specifically 
        //congratulating them on being the winner.

        public void NotifyEachContestants()
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;            // assign operator; ex. y = x+1                                                                                            // contestantsDictionary.TryGetValue(winnerContestant, out winner);            // TryGetValue to pick winner
            //foreach (KeyValuePair<int, Contestant> pair in contestantsDictionary)
            //{
                if (winner == contestantsDictionary[winnerContestant])
                {
                    Console.WriteLine("Congratulation, you're the winner!");
                }
                else
                {
                    Console.WriteLine("Sorry, you're not the winner!");
                }
            //}
        }

        //(5 points) As a developer, I want to send an actual email to a sweepstakes winner using an 
        //MailKit API https://github.com/jstedfast/MailKit

        public void NotifyWinnerEmail(Contestant contestant)
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;            // assign operator; ex. y = x+1
            winner = contestantsDictionary[winnerContestant];

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Shee Yee Chang", "sheeyee@gmail.com"));
            message.To.Add(new MailboxAddress(contestant.emailAddress));
            message.Subject = "You're The Sweepstakes Winner 2019";
            message.Body = new TextPart("plain")
            {
                Text = @"Congratulation, you're the winner!"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("sheeyeechang@gmail.com", "devCodeCamp19");
                client.Send(message);
                client.Disconnect(true);
            }
           Console.WriteLine("MessageSent");
        }

    }
}





