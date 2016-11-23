using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    class cosinus:Computer.Computer
    {
        public string Name
        {
            get { return "Cosinus"; }
        }
        public double Execute(params string[] value)
        {
            double angle = Convert.ToDouble(value);
            
            return Math.Cos(angle);
        }

    }
}
