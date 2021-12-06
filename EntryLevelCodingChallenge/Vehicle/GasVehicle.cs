using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class GasVehicle : Vehicle
    {
        public enum CylinderCount
        {
            Four,
            Six,
            Eight
        }

        private CylinderCount engineSize;

        internal CylinderCount EngineSize
        {
            get => engineSize; set => engineSize = value;
        }


        public GasVehicle(string manufacturer, string model, DateTime yearBuilt, ConsoleColor color, CylinderCount engineSize)
            : base(manufacturer, model, yearBuilt, color)
        {
            this.engineSize = engineSize;
        }

        public override void AcceptVisitor(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            string baseToString = base.ToString();
            StringBuilder strBuilder = new StringBuilder(baseToString);
            string strEngineS = engineSize.ToString();
            strBuilder.AppendFormat("{0}", strEngineS.PadLeft(Utility.SpecializationColPad));
            return strBuilder.ToString();
        }

       
    }
}
