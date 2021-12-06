using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    abstract class Vehicle : IVehicle
    {
        protected ConsoleColor color;
        public ConsoleColor Color { get => color; }

        protected string manufacturer;
        protected string model;
        protected DateTime yearBuilt;
        
        public abstract void AcceptVisitor(Visitor visitor);        

        public Vehicle(string manufacturer, string model, DateTime yearBuilt, ConsoleColor color)
        {
            this.yearBuilt = yearBuilt;
            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
        }

        private int Calculate()
        {
            int age = DateTime.Now.Year - yearBuilt.Year;
            return age;
        }

        public override string ToString()
        {
            string strColor = color.ToString();
            string strYear = yearBuilt.Year.ToString();
            string strAge = Calculate().ToString();
            
            string strVehicleInfo = FormatVehicleInfo(manufacturer, model, strColor, strYear, strAge);
            return strVehicleInfo;
        }

        private string FormatVehicleInfo(string manufacturer, string model, string color, string year, string age)
        {
            StringBuilder strBuilder = new StringBuilder();
            const int pad = Utility.COLUMN_PAD;
            strBuilder.AppendFormat("{0}{1}{2}{3}{4}", manufacturer.PadRight(pad), model.PadLeft(pad),
                color.PadLeft(pad), year.PadLeft(pad), age.PadLeft(pad));

            return strBuilder.ToString();
        }
       
    }
}
