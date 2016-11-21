using System;

namespace Computer
{
    public class Adder : Computer
    {
        public string Name
        {
            get { return "Adder"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;
            foreach (string v in values)
            {
                result += Convert.ToDouble(v);
            }
            return result;
        }
    }
}
