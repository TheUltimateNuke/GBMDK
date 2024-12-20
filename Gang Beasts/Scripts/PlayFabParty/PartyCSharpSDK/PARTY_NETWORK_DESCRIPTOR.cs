using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_NETWORK_DESCRIPTOR
	{
		public string NetworkIdentifier { get; }

		public string RegionName { get; }

		public byte[] OpaqueConnectionInformation { get; }

		internal PARTY_NETWORK_DESCRIPTOR(PartyCSharpSDK.Interop.PARTY_NETWORK_DESCRIPTOR interopStruct)
		{
		}
	}
}
