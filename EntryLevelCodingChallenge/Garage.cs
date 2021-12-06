using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class Garage
    {
        List<Vehicle> vehicles ;
        public Garage( int numOfVehciles)
        {
            vehicles = GenVehicles(numOfVehciles);
        }
        
        private List<Vehicle> GenVehicles(int numOfVehicles)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            VehicleFactory[] factories = { new FordFactory(), new HondaFactory() };

            for (int i = 0; i < numOfVehicles; i++)
            {
                int factoryIndex = Utility.RandomNumber(0, factories.Length);

                int vehicleType = Utility.RandomNumber(0, 2);

                Vehicle vehicle;
                if (vehicleType == 1)
                {
                    vehicle = factories[factoryIndex].CreateElectricVehicle();

                }
                else
                {
                    vehicle = factories[factoryIndex].CreateGasVehicle();
                }
                vehicles.Add(vehicle);
            }
            return vehicles;
        }

        public void SortGarageByType()
        {
            vehicles = vehicles.OrderBy(x => x.GetType().Name).ToList();
        }

        public void Render(RendererVisitor rendererVisitor)
        {
            ConsoleRenderer.WriteLine(Utility.CreateListHeader(), ConsoleColor.DarkGray);

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.AcceptVisitor(rendererVisitor);
            }
        }

    }
}
