using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAutoPilot
{
    public interface ILaunchVechicle
    {
        // 1
        void IgniteBoosters();

        // 2
        void PowerOnBoosters();

        // 3
        void SeparateBoosters();

        // 4
        void PowerOnMainEngine();

        // 5
        void PowerOffMainEngine();

        // 6
        void SeparateMainEngine();

        // 7
        void PowerOnSpaceShipEngine();

        // 8
        void EnableSpaceShipAutoPilot();
    }


    class LaunchVehicleAutoPilot
    {
        public void ExecuteLaunch(ILaunchVechicle launchVehicle)
        {
            launchVehicle.IgniteBoosters();
            launchVehicle.PowerOnBoosters();
            launchVehicle.PowerOnSpaceShipEngine();
            launchVehicle.SeparateBoosters();
            launchVehicle.EnableSpaceShipAutoPilot();
        }
    }

    public class SpaceShipComponents : ILaunchVechicle
    {
        private int counter;

        private string errorMesage = "Follow the instructions.";

        public SpaceShipComponents()
        {
            counter = 0;
        }

        private void Reset()
        {
            counter = 0;
            throw new Exception(errorMesage);
        }
        public void EnableSpaceShipAutoPilot()
        {
            if (counter != 7) Reset();
            else counter = 8;
        }
        public void IgniteBoosters()
        {
            if (counter != 0) Reset();
            else counter = 1;
        }
        public void PowerOffMainEngine()
        {
            if (counter != 4) Reset();
            else counter = 5;
        }
        public void PowerOnBoosters()
        {
            if (counter != 1) Reset();
            else counter = 2;
        }
        public void PowerOnMainEngine()
        {
            if (counter != 3) Reset();
            else counter = 4;
        }
        public void PowerOnSpaceShipEngine()
        {
            if (counter != 6) Reset();
            else counter = 7;
        }
        public void SeparateBoosters()
        {
            if (counter != 2) Reset();
            else counter = 3;
        }
        public void SeparateMainEngine()
        {
            if (counter != 5) Reset();
            else counter = 6;
        }
    }
}
