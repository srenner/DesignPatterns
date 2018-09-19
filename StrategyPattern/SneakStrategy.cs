using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SneakStrategy : IStrategy
    {
        public bool DidIWin { get; set; }

        public void ImplementStrategy()
        {
            Console.WriteLine("Hang back for a while, and sneak up on the competition at the very end.");
            this.DidIWin = false;
        }
    }
}
