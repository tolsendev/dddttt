namespace Tycoon
{
    internal interface IVehicle
    {
        void Load(Cargo cargo, Route route);
        void Unload(Cargo cargo);
    }
}