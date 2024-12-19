using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_NETWORK_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_NETWORK_HANDLE InteropHandle { get; set; }

		internal PARTY_NETWORK_HANDLE(PartyCSharpSDK.Interop.PARTY_NETWORK_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_NETWORK_HANDLE interopHandle, out PARTY_NETWORK_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
