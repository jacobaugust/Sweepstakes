using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory : IGetManager
    {
       

        public ISweepstakesManager GetManagerToUse()
        {

            switch(UserInterface.managerSelection.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return null;
            }
        }

    }
}
