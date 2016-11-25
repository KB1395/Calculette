using System;

namespace Calcu_lib
{
    public class Adder : Computer.Computer
    {
        public string Name
        {
            get { return "Adder"; }
        }
        public string Description
        {
            get { return "[n1 n2 n3]             Adds the n's (separated with a space)"; }
        }


        public string Execute(params string[] values)
        {
            double result = 0;
            foreach (string v in values)
            {
                
                try
                {
                    result += Convert.ToDouble(v);
                
                }
                catch
                {
                    
                    return "Parameters error";
                }
            }
            return Convert.ToString(result);
        }
    }
}
