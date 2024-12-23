using System.Runtime.InteropServices;

namespace SynchronizerData
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct BeatDecimalValues
	{
		private static float dottedBeatModifier;

		public static float[] values;
	}
}
