using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    abstract class VehicleFactory
    {
        public abstract Vehicle CreateGasVehicle();
        public abstract Vehicle CreateElectricVehicle();

        const int MIN_YEAR = 1990;
        const int MAX_YEAR = 2021;

        protected DateTime GenYearBuilt()
        {
            int year = Utility.RandomNumber(MIN_YEAR, MAX_YEAR);
            DateTime yearBuilt = new DateTime(year, 1, 1);
            return yearBuilt;
        }

        protected ConsoleColor GenColor()
        {
            int color = Utility.RandomNumber(0, 1+(int)ConsoleColor.White);
            return (ConsoleColor)color;
        }

        protected string GenModel(string[] models)
        {
            int modelIndex = Utility.RandomNumber(0, models.Length);
            return models[modelIndex];
        }

        protected ElectricVehicle.Motor GenMotorType()
        {
            int type = Utility.RandomNumber(0, 1+(int)ElectricVehicle.Motor.Dual);
            return (ElectricVehicle.Motor)type;
        }

        protected GasVehicle.CylinderCount GenEngineSize()
        {
            int count = Utility.RandomNumber(0, 1+ (int)GasVehicle.CylinderCount.Eight);
            return (GasVehicle.CylinderCount)count;
        }
    }
}
