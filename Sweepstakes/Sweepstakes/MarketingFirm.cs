using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm 
    {
        public string managerSelection;
        Contestant contestant;

        public MarketingFirm()
        {
            
        }

        ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }
        public void ManagerSelection()
        {
            UserInterface.GetSweepstakesManager();
            sweepstakesFactory.GetManagerToUse(managerSelection);
        }
        public void ContestantCollection()
        {
            contestant = new Contestant();
            UserInterface.GetFirstName(contestant);
            UserInterface.GetLastName(contestant);
            UserInterface.GetEmail(contestant);
            UserInterface.GetRegistration(contestant);
        }
    }
}
