using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION
	{
		public PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_OPTIONS options { get; set; }

		public ushort port { get; set; }

		internal PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION(PartyCSharpSDK.Interop.PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION interopStruct)
		{
		}

		public PARTY_LOCAL_UDP_SOCKET_BIND_ADDRESS_CONFIGURATION()
		{
		}
	}
}
