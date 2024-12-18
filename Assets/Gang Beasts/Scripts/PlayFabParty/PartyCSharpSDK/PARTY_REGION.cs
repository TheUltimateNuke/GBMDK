using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_REGION
	{
		public string RegionName { get; }

		public uint RoundTripLatencyInMilliseconds { get; }

		internal PARTY_REGION(PartyCSharpSDK.Interop.PARTY_REGION interopStruct)
		{
		}
	}
}
