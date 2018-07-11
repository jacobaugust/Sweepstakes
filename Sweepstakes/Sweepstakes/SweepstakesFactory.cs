using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory : IGetManager
    {
       

        public ISweepstakesManager GetManagerToUse(marketingFirm.managerSelection)
        {

            switch(manager.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    Console.WriteLine("Not a valid Sweepstakes Manager.");
            }
        }

    }
}
