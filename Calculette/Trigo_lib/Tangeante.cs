using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    class tan : Computer.Computer
    {
        public string Name
        {
            get { return "Cosinus"; }
        }
        public double Execute(params string[] values)
        {
            string value = values[0];
            double angle = Convert.ToDouble(value);

            return Math.Tan(angle);
        }

    }
}
