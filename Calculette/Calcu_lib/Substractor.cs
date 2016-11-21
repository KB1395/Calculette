using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substractor
{
    public class Substractor : Computer.Computer
    {
        public string Name
        {
            get { return "Substractor"; }
        }
        public double Execute(params string[] values)
        {
            double result = Convert.ToDouble(values[0]);
            foreach (string v in values)
            {
                result -= Convert.ToDouble(v);
                
            }
            return (result + Convert.ToDouble(values[0]));
        }
    }
}

