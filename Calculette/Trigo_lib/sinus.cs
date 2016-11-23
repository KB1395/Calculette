using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    public class sinus:Computer.Computer
    {
        public string Name
        {
            get { return "sin(x)"; }
        }
        public double Execute(params string[] value)
        {
            
            double angle = Convert.ToDouble(value);
            
            return Math.Sin(angle);
        }


    }
}
