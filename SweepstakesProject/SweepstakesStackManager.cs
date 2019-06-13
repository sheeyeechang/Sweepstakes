using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variable (HAS A)
        Stack<Sweepstakes> stack;

        //constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(10 points) As a developer, I want to create a SweepstakesStackManager class that uses the 
        //Stack data structure as an underlying structure.

        //stack.Push(); insert an object at the top of the Stack.
        //stack.Pop(); delete/remove an object at the top of the Stack.

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = stack.Pop();
            return sweepstakes;
        }

    }
}
