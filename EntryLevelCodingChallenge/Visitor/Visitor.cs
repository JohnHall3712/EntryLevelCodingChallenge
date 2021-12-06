using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    abstract class Visitor
    {
        public abstract void Visit(GasVehicle gasVehicle);
        public abstract void Visit(ElectricVehicle electricVehicle);
    }
}
