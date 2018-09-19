using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Engine
    {
        public bool IsReady(Mechanic mechanic)
        {
            Console.WriteLine("{0} is performing a compression test", mechanic.Name);
            return true;
        }
    }
}
