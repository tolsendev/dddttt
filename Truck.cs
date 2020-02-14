using System;
using System.Collections.Generic;
using System.Text;

namespace Tycoon
{
    class Truck : ITickListener, IVehicle
    {
        public Cargo Cargo { get; set; }
        public Route Route { get; private set; }
        private int RemainingTicks;
        public void Tick()
        {
            RemainingTicks--;

            if(RemainingTicks == 0)
            {

            }
        }

        public void Load(Cargo cargo, Route route)
        {
            Cargo = cargo;
            Route = route;
            RemainingTicks = route.Cost;
        }

        public void Unload(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}
