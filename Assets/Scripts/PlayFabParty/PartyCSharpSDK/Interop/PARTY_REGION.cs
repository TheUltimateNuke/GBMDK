using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_REGION
	{
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003CregionName_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		private unsafe fixed byte regionName[20];

		internal readonly uint roundTripLatencyInMilliseconds;

		internal string GetRegionName()
		{
			return null;
		}

		internal PARTY_REGION(PartyCSharpSDK.PARTY_REGION publicObject)
		{
			roundTripLatencyInMilliseconds = 0u;
		}
	}
}
