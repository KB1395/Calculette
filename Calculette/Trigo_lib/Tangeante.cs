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
            get { return "Tangeante"; }
        }
        public string Description
        {
            get { return "[angle]                  tangent of angle in rad"; }
        }

        public string Execute(params string[] values)
        {
            if(values.Length > 1)
            {

                return "Too many arguments (only one needed)";
            }
            else
            {
                string value = values[0];
                try
                {
                    double angle = Convert.ToDouble(value);

                    return Convert.ToString(Math.Tan(angle));
                }
                catch
                {

                    return "Wrong parameters input";
                }


            }
        }

    }
}
