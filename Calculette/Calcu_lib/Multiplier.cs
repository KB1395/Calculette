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
        public string Description
        {
            get { return "[n1 n2 n3]        Multiplies the n's (separated with a space)"; }
        }

        public string Execute(params string[] values)
        {
            try
            {

                double result = Convert.ToDouble(values[0]);
                foreach (string v in values)
                {

                    
                    result = result * Convert.ToDouble(v);
                }
                return Convert.ToString(result / Convert.ToDouble(values[0]));
            }
            catch
            {
                
                return "Wrong parameters input";
            }
        }
    }
}