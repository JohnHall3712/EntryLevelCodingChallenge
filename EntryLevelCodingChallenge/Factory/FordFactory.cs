using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class FordFactory : VehicleFactory
    {
        string[] models = { "Ranger", "Escape", "Mustang", "Ford GT", "Bronco" };
        const string manufacturer = "Ford"; 
        public override Vehicle CreateElectricVehicle()
        {
            Vehicle eV = new ElectricVehicle(manufacturer, GenModel(models),
                    GenYearBuilt(), GenColor(), GenMotorType());
            return eV;
        }

        public override Vehicle CreateGasVehicle()
        {
            Vehicle gV = new GasVehicle(manufacturer, GenModel(models),
                     GenYearBuilt(), GenColor(), GenEngineSize());
            return gV;
        }
    }
}
