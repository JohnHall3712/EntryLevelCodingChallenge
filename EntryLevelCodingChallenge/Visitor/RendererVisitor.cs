using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class RendererVisitor : Visitor
    {

        public override void Visit(ElectricVehicle electricVehicle)
        {
            string vehicleInfo = electricVehicle.ToString();
            ConsoleRenderer.WriteLine(vehicleInfo);
        }

        public override void Visit(GasVehicle gasVehicle)
        {
            string vehicleInfo = gasVehicle.ToString();
            ConsoleRenderer.WriteLine(vehicleInfo);
        }
    }
}
