using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variable (HAS A)
        Queue<Sweepstakes> queue;
        //constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(10 points) As a developer, I want to create a SweepstakesQueueManager class that uses the 
        //Queue data structure as an underlying structure.
        //queue.Enqueue(); Adds an object to the end of the Queue.
        //queue.Dequeue(); Removes and returns the object at the beginning of the Queue.

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = queue.Dequeue();
            return sweepstakes;
        }


    }
}
