using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differential_lib
{
    public class Differential
    {
        public string Name
        {
            get { return "Differential"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;
            foreach (string v in values)
            {
                Console.WriteLine(v);
                result += Convert.ToDouble(v);
            }
            return result;
        }

    }
}
