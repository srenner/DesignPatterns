using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StrategyContext
    {
        public IStrategy Strategy { get; set; }

        public StrategyContext(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void SetRaceStrategy()
        {
            Strategy.ImplementStrategy();
        }
    }
}
