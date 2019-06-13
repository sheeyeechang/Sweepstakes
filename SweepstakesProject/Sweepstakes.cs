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
            contestant.registrationNumber = contestantsDictionary.Count + 1;
            contestantsDictionary.Add(contestant.registrationNumber, contestant);
        }
        // random select winner from dictionary
        public string PickWinner()
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;
            contestantsDictionary.TryGetValue(winnerContestant, out winner);
            string name = "First Name: " + winner.firstName + " Last Name: " winner.lastName + " Registration Number: " + winner.registrationNumber;
            return name;

            //    TValue value;
            //    // attempt to get the value of the key from the dictionary
            //    dictionary.TryGetValue(key, out value);
            //    return value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}");
            Console.WriteLine($"Last Name: {contestant.firstName}");
            Console.WriteLine($"Email: {contestant.emailAddress}");
            Console.WriteLine($"Registration Number: {contestant.registrationNumber}");
            Console.ReadLine();
        }



    }
}













    //public class DictionaryExamples
    //{
    //    public void DisplayAnimalCategorization()
    //    {
    //        Dictionary<string, string> animals = new Dictionary<string, string>();
    //        animals.Add("cat", "feline");
    //        animals.Add("dog", "canine");

    //        foreach (KeyValuePair<string, string> pair in animals)
    //        {
    //            Console.WriteLine(pair.Key + " - " + pair.Value);
    //        }
    //    }
    //    public void DisplayMonthSeason()
    //    {
    //        Dictionary<string, string> monthsInSeason = new Dictionary<string, string>();
    //        monthsInSeason.Add("December", "winter");
    //        monthsInSeason.Add("July", "summer");
    //        monthsInSeason.Add("October", "fall");
    //        monthsInSeason.Add("April", "spring");

    //        Console.Write("Enter a month: ");
    //        string key = (Console.ReadLine());

    //        foreach (KeyValuePair<string, string> month in monthsInSeason)
    //        {
    //            if (month.Key == key)
    //                Console.WriteLine("Month " + month.Key + " is of season " + month.Value);
    //        }
    //    }
    //    public void DisplayEmployeeIdName()
    //    {
    //        Dictionary<int, string> employees = new Dictionary<int, string>();
    //        employees.Add(1337, "Terrill");
    //        employees.Add(1234, "Heinisch");
    //        employees.Add(9541, "Carlson");

    //        Console.Write("Enter an employee name: ");
    //        string value = Console.ReadLine();
    //        foreach (KeyValuePair<int, string> employee in employees)
    //        {
    //            if (employee.Value == value)
    //                Console.WriteLine($"Employee ID: {employee.Key} Employee Name: {employee.Value}");
    //        }
    //    }
    //}



