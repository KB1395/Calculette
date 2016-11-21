using System;

namespace Calcu_lib
{
    public class Adder : Computer.Computer
    {
        public string Name
        {
            get { return "Adder"; }
        }

        public double Execute(params string[] values)
        {
            double result = Convert.ToDouble(values[0]);
            foreach (string v in values)
            {
                result += Convert.ToDouble(v);
            }
            return result;
        }
    }
}
