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
        public string Description
        {
            get { return "Substracts the numbers after the command (separate every number by a space)"; }
        }

        public string Execute(params string[] values)
        {
            try
            {
                double result = Convert.ToDouble(values[0]);
                foreach (string v in values)
                {
                    result -= Convert.ToDouble(v);

                }
                return Convert.ToString(result + Convert.ToDouble(values[0]));
            }
            catch
            {
                
                return "Wrong parameters input";
            }
        }
    }
}

