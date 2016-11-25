using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    public class sin:Computer.Computer
    {
        public string Name
        {
            get { return "sin"; }
        }
        public string Description
        {
            get { return "[angle]                  sine of angle in rad"; }
        }

        public string Execute(params string[] values)
        {

            if (values.Length > 1)
            {
                
                return "Too many arguments (only one needed)";
            }
            else
            {
                string value = values[0];
                try
                {
                    double angle = Convert.ToDouble(value);

                    return Convert.ToString(Math.Sin(angle));
                }
                catch
                {
                    
                    return "Wrong parameters input";
                }


            } 
           
        }


    }
}
