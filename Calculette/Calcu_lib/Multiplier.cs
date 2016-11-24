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
            try
            {

                double result = Convert.ToDouble(values[0]);
                foreach (string v in values)
                {

                    Console.WriteLine(v);
                    result = result * Convert.ToDouble(v);
                }
                return (result / Convert.ToDouble(values[0]));
            }
            catch
            {
                Console.WriteLine("Wrong parameters input");
                return 0;
            }
        }
    }
}