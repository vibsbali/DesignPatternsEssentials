namespace InitialHierarchy.Vehicle
{
    interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour color);
    }
}
