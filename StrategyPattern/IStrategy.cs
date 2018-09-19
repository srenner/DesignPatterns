using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IStrategy
    {
        void ImplementStrategy();

        bool DidIWin { get; set; }
    }
}
