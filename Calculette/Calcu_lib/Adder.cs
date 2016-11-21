using System;

namespace Calcu_lib
{
	public class Adder : Computer.Computer
	{
		public string Name
		{
			get { return "Adder"; }
		}

		public double Compute (params double[] values)
		{
			double result = 0;
			Array.ForEach (values, value => result += value);
			return result;
		}
	}
}
