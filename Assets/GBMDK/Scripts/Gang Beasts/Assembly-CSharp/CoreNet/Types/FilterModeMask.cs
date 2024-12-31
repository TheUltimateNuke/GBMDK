using System;

namespace CoreNet.Types
{
	[Flags]
	public enum FilterModeMask
	{
		NONE = 0,
		Survival = 1,
		CaptureTheFlag = 2,
		KingOfTheHill = 4,
		ALL = 7
	}
}
