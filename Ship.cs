using System;
using System.Collections.Generic;
using System.Text;

namespace Tycoon
{
    class Ship : ITickListener, IVehicle
    {
        public Cargo Cargo { get; set; }

        public void Load(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public void Unload(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}
