using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class BigLeadStrategy : IStrategy
    {
        public bool DidIWin { get; set; }

        public void ImplementStrategy()
        {
            Console.WriteLine("Start out fast and build an insurmountable lead.");
            this.DidIWin = false;
        }
    }
}
