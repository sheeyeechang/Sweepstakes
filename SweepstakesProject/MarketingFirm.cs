﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        //member variable (HAS A)
        ISweepstakesManager sweepstakesManager;
        //constructor dependency injection
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.sweepstakesManager = manager;
        }
        //method (CAN DO)  ------------------------------------------------------------------------------------------------
        //(10 points) As a developer, I want to implement dependency injection in my MarketingFirm class
        //so that I can utilize a sweepstakes manager.


    }
}
