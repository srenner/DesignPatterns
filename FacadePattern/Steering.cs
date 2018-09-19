using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Steering
    {
        public bool IsReady(Mechanic mechanic)
        {
            Console.WriteLine("{0} is checking the steering system", mechanic.Name);
            return true;
        }

    }
}
