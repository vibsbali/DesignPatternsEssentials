namespace InitialHierarchy.Vehicle.Cars
{
    public class Sports : AbstractCar
    {
        public Sports(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Sports(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}