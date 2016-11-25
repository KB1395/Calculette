using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    //using the computer interface 
    class cos :Computer.Computer
    {
        public string Name
        {
            get { return "Cosinus"; }
        }
        public string Description
        {
            get { return "[angle]                  cosine of angle in "; }
        }

        public string Execute(params string[] values)
        {
            try
            {
                if (values.Length > 1)
                {
                    
                    return "Too many arguments (only one needed)";
                }
                else
                {
                    string value = values[0];
                    double angle = Convert.ToDouble(value);

                    return Convert.ToString(Math.Cos(angle));

                }
            }
            catch
            {
                
                return "Wrong parameters input";
            }

        }

    }
}
