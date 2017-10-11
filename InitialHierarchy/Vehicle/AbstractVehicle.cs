using System;
using System.Collections.Generic;
using System.Text;

namespace InitialHierarchy.Vehicle
{
    public abstract class AbstractVehicle : IVehicle
    {
        public virtual IEngine Engine { get; private set; }

        public virtual VehicleColour Colour { get; private set; }

        //Notice the use of 'this' keyword for passing the values to the overloaded constructor that takes two parameters
        protected AbstractVehicle(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        protected AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            Engine = engine;
            Colour = colour;
        }

        public virtual void Paint(VehicleColour color)
        {
            Colour = color;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({Engine}),({Colour})";
        }
    }
}
