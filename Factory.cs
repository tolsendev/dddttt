using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tycoon
{
    class Factory : ILocation
    {
        public Queue<Cargo> cargos = new Queue<Cargo>(new List<Cargo>() { new Cargo("A"), new Cargo("A"), new Cargo("B"), new Cargo("A"), new Cargo("B"), new Cargo("B"), new Cargo("A"), new Cargo("B") });

        private Route routea;
        private Route routeb;

        public Factory(Route routea, Route routeb)
        {
            this.routea = routea;
            this.routeb = routeb;
        }

        public void TruckHasArrived(Truck truck)
        {
            var cargo = cargos.Dequeue();
            truck.LoadCargo(cargo, cargo.Destination == "A" ? routea : routeb);
        }

        public Cargo MakeNextProducedGoods()
        {
            return null;
        }
    }
}
