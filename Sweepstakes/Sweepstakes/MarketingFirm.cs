using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm 
    {
        
        Contestant contestant;
        SweepstakesFactory sweepstakesFactory;
        Sweepstakes sweepstakes;
        ISweepstakesManager manager;
        int registrationNumber;
        

        public MarketingFirm(ISweepstakesManager manager)
        {
            sweepstakes = new Sweepstakes();
            this.manager = manager;
            ManagerSelection();
            ContestantCollection();
            ContestantCollection();
            ContestantCollection();
            ContestantCollection();
            sweepstakes.PickWinner();
            
        }
        public void ManagerSelection()
        {
            UserInterface.GetSweepstakesManager();
            sweepstakesFactory = new SweepstakesFactory();
            sweepstakesFactory.GetManagerToUse();
        }
        public void ContestantCollection()
        {
            registrationNumber++;
            contestant = new Contestant(registrationNumber);
            UserInterface.GetFirstName(contestant);
            UserInterface.GetLastName(contestant);
            UserInterface.GetEmail(contestant);
            sweepstakes.RegisterContestant(contestant);
        }
    }
}
