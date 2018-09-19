using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Car
    {
        private Engine _engine = new Engine();
        private Brakes _brakes = new Brakes();
        private Steering _steering = new Steering();

        public bool IsSafeToDrive(Mechanic mechanic)
        {
            bool isSafe = true;

            isSafe = _engine.IsReady(mechanic);

            if(isSafe)
            {
                isSafe = _brakes.IsReady(mechanic);
            }

            if(isSafe)
            {
                isSafe = _steering.IsReady(mechanic);
            }

            return isSafe;
        }
    }
}
