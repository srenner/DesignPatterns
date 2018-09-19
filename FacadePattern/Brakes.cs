using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Brakes
    {
        public bool IsReady(Mechanic mechanic)
        {
            Console.WriteLine("{0} is checking the brake pads", mechanic.Name);
            Console.WriteLine("Brake pads show too much wear!");
            return false;
        }

    }
}
