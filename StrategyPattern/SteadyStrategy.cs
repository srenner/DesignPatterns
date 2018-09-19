using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SteadyStrategy : IStrategy
    {
        public bool DidIWin { get; set; }

        public void ImplementStrategy()
        {
            Console.WriteLine("Go at your best steady pace.");
            this.DidIWin = true;
        }
    }
}
