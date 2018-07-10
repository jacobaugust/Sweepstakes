using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string name;
        Dictionary<int, Contestant> SweepstakesLog = new Dictionary<int, Contestant>();

        public Sweepstakes()
        {
            

        }

        public void SweepstakesName()
        {
            Console.WriteLine("Please enter the name or title of the Sweepstakes:");
            name = Console.ReadLine();
        }
        void RegisterContestant(Contestant contestant)
        {
            SweepstakesLog.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            int winningRegistrationNumber;
            Random rnd = new Random();
            winningRegistrationNumber = rnd.Next(1, SweepstakesLog.Count + 1);
            Contestant winner = SweepstakesLog[winningRegistrationNumber];
            return winner.ToString();
        }
        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.firstName + " " + contestant.lastName + "\nEmail: " + contestant.email + "\nRegistration: " + contestant.registrationNumber + "");
        }
    }
}
