using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        string name;
        int maxContestants;
        Dictionary<int, Contestant> SweepstakesLog = new Dictionary<int, Contestant>();

        public Sweepstakes()
        {
            SweepstakesName();
            SweepstakesTotalContestants();

        }

        public void SweepstakesName()
        {
            Console.WriteLine("Please enter the name or title of the Sweepstakes:");
            name = Console.ReadLine();
        }
        public void SweepstakesTotalContestants()
        {
            Console.WriteLine("What is the maximum number of contestents?");
            maxContestants = Int32.Parse((Console.ReadLine()));

        }
        public void RegisterContestant(Contestant contestant)
        {
            SweepstakesLog.Add(contestant.registrationNumber, contestant);
            PrintContestantInfo(contestant);
        }
        public string PickWinner()
        {
            int winningRegistrationNumber;
            Random rnd = new Random();
            winningRegistrationNumber = rnd.Next(1, SweepstakesLog.Count + 1);
            Contestant winner = SweepstakesLog[winningRegistrationNumber];
            winner.ToString();
            Console.WriteLine("\n\nContestant Winner Info:\n\n" + winner.firstName + "" + winner.lastName + "\nEmail: " + winner.email + "");
            Console.ReadLine();
            return winner.ToString();
        
        } 

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("\n\nContestant Info Check:\n\nName: " + contestant.firstName + " " + contestant.lastName + "\nEmail: " + contestant.email + "\nRegistration: " + contestant.registrationNumber + "");
            Console.ReadLine();
        }
    }
}
