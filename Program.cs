using System;

namespace Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Route routea = new Route() { Destination = "A", Cost = 1 };
            Route routeb = new Route() { Destination = "B", Cost = 5 };
            Factory factory = new Factory(routea, routeb);

            Truck t1 = new Truck();
            factory.TruckHasArrived(t1);

            Truck t2 = new Truck();
            factory.TruckHasArrived(t2);

            Ship ship = new Ship();

            Warehouse wa = new Warehouse();
            Warehouse wb = new Warehouse();
            Port port = new Port();
            Route routec = new Route() { Destination = "A", Cost = 4 };
            TimeManager time = new TimeManager(t1, t2, ship);

            Console.WriteLine("Lets go");
            while (factory.cargos.Peek() != null) {
                time.Tick();
            }
        }
    }
}
