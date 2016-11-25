using System;

namespace Computer
{
    //Creation of the intefrace used in every operation
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