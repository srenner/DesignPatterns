using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Mechanic
    {
        public string Name { get; }

        public Mechanic(string name)
        {
            this.Name = name;
        }
    }
}
