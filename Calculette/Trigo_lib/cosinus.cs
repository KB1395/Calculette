using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigo_lib
{
    class cos:Computer.Computer
    {
        public string Name
        {
            get { return "Cosinus"; }
        }
        public double Execute(params string[] values)
        {
            try
            {
                if (values.Length > 1)
                {
                    Console.WriteLine("Too many arguments (only one needed)");
                    return 0;
                }
                else
                {
                    string value = values[0];
                    double angle = Convert.ToDouble(value);

                    return Math.Cos(angle);

                }
            }
            catch
            {
                Console.WriteLine("Wrong parameters input");
                return 0;
            }

        }

    }
}
