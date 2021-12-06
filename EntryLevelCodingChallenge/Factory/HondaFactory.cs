using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class HondaFactory : VehicleFactory
    {
        string[] models = { "Civic", "Accord", "CR-V", "Odyssey", "Ridgeline" };
        const string manufacturer = "Honda";
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
