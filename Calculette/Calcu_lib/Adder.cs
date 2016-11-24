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
            double result = 0;
            foreach (string v in values)
            {
                Console.WriteLine(v);
                try
                {
                    result += Convert.ToDouble(v);
                }
                catch
                {
                    Console.WriteLine("Parameters error");
                    result = 0;
                }
            }
            return result;
        }
    }
}
