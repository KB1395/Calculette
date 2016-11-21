using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu_lib
{
    public class Multiplier : Computer.Computer
    {
        public string Name
        {
            get { return "Multiplier"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;
            foreach (string v in values)
            {
                result = Convert.ToDouble(v) * Convert.ToDouble(v);
            }
            return result;
        }
    }
}