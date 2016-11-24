using System;

namespace Computer
{
	public interface Computer
	{
		string Name
		{
			get;
		}
        string Description
        {
            get;
        }

		string Execute (params string[] values);
	}
}