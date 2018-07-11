using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        //Last In (last entered/newest), First Out

        public SweepstakesStackManager(Sweepstakes sweepstakes)
        {
            Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(Sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {

        }
      

    }
}
