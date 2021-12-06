using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    static class Utility
    {
        public const int COLUMN_PAD = 14;
        static public int SpecializationColPad = 23;
        static private Random rng = null;
        static public int RandomNumber(int min, int max)
        {
            if (rng == null)
            {
                rng = new Random(DateTime.Now.Millisecond);
            }            
            return rng.Next(min, max);
        }

        static public string CreateListHeader()
        {
            StringBuilder strBuilder = new StringBuilder();
            const int pad = Utility.COLUMN_PAD;

            string manufacturer = "Manufacturer";
            string model = "Model";
            string color = "Color";
            string year = "Year";
            string age = "Age";
            string motorOrEngine = "MotorType/EngineSize";

            strBuilder.AppendFormat("{0}{1}{2}{3}{4}{5}", manufacturer.PadRight(pad), model.PadLeft(pad),
                color.PadLeft(pad), year.PadLeft(pad), age.PadLeft(pad), motorOrEngine.PadLeft(SpecializationColPad));
            return strBuilder.ToString();
        }
    }
}
