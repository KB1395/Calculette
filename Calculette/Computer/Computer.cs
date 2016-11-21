using System;

namespace Computer
{
	public interface Computer
	{
		string Name
		{
			get;
		}

		double Execute (params string[] values);
	}
}