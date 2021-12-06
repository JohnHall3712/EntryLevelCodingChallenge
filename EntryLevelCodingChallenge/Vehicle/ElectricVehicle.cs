using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    class ElectricVehicle : Vehicle
    {
        public enum Motor
        {
            Single,
            Dual
        }

        private Motor motorType;

        internal Motor MotorType { get => motorType; set => motorType = value; }

        public ElectricVehicle(string manufacturer, string model, DateTime yearBuilt, ConsoleColor color, Motor motorType)
            : base(manufacturer, model, yearBuilt, color)
        {
            this.motorType = motorType;
        }

        public override void AcceptVisitor(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            string baseToString = base.ToString();
            StringBuilder strBuilder = new StringBuilder(baseToString);

            string strMotor = motorType.ToString();

            strBuilder.AppendFormat("{0}", strMotor.PadLeft(Utility.SpecializationColPad));
            return strBuilder.ToString();
        }
    }
}
