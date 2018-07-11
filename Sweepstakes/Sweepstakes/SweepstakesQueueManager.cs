using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //First In (first arrived/oldest), First Out
        public SweepstakesQueueManager()
        {
            Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(Sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {

        }
    }
}
