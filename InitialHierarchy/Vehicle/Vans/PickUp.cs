namespace InitialHierarchy.Vehicle.Vans
{
    public class PickUp : AbstractVan
    {
        public PickUp(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public PickUp(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}