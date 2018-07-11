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
        

        public MarketingFirm()
        {
            sweepstakes = new Sweepstakes();
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
            contestant = new Contestant();
            UserInterface.GetFirstName(contestant);
            UserInterface.GetLastName(contestant);
            UserInterface.GetEmail(contestant);
            UserInterface.GetRegistration(contestant);
            sweepstakes.RegisterContestant(contestant);
        }
    }
}
