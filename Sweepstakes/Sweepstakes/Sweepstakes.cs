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
        Contestant contestant;

        public Sweepstakes()
        {
            contestant = new Contestant();
            List<Contestant> ContestantList = new List<Contestant>();

        }

        public void SweepstakesName()
        {
            Console.WriteLine("Please enter the name or title of the Sweepstakes:");
            name = Console.ReadLine();
        }
        void RegisterContestant(Contestant contestant)
        {
            
        }
        public string PickWinner()
        {

        }
        void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
