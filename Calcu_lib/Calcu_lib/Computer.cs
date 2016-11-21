using System;

namespace Cours5
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
