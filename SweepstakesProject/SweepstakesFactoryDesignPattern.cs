using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesFactoryDesignPattern
    {
        //member variable (HAS A)
        //constructor
        public SweepstakesFactoryDesignPattern()
        {
        }
        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(10 points) As a developer, I want to use the factory design pattern to allow a user to choose between a 
        //SweepstakesStackManager or a SweepstakesQueueManager to manage the sweepstakes objects.
        //how to get the stack or queue to sweepstakes and each manager 

        //The Factory method is a creational design pattern which provides an interface for creating objects 
        //without specifying their concrete classes. It defines a method which we can use to 
        //create an object instead of using its constructor.

        public ISweepstakesManager ChooseSweepstakesTypeManager(string user)
        {
            switch (user)
            {
                case "queue":
                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    return sweepstakesQueueManager;
                case "stack":
                    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                    return sweepstakesStackManager;
                default:
                    return ChooseSweepstakesTypeManager(user);
            }

        }
    }
}
