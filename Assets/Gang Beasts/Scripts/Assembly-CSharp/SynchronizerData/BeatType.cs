using System;

namespace SynchronizerData
{
	[Flags]
	public enum BeatType
	{
		None = 0,
		OffBeat = 1,
		OnBeat = 2,
		UpBeat = 4,
		DownBeat = 8
	}
}
