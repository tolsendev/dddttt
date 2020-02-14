namespace Tycoon
{
    internal interface ILocation
    {
        void OnArrive(IVehicle truck);
        void OnLeave(IVehicle truck);
    }
}