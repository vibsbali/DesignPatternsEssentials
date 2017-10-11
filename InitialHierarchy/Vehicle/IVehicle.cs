using System;
using System.Collections.Generic;
using System.Text;

namespace InitialHierarchy
{
    interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour color);
    }
}
