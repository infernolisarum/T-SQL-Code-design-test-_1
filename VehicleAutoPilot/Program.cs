using System;

namespace VehicleAutoPilot
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceShipComponents spaceShipComponents = new SpaceShipComponents();

            LaunchVehicleAutoPilot autoPilot = new LaunchVehicleAutoPilot();
            autoPilot.ExecuteLaunch(spaceShipComponents);
        }
    }
}
