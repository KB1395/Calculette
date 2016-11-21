using System;

namespace Computer
{
	public interface Computer
	{
		string Name
		{
			get;
		}

		double Compute (params double[] values);
	}
}
