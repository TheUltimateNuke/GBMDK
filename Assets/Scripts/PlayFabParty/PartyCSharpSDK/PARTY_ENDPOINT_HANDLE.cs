using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_ENDPOINT_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_ENDPOINT_HANDLE InteropHandle { get; set; }

		internal PARTY_ENDPOINT_HANDLE(PartyCSharpSDK.Interop.PARTY_ENDPOINT_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_ENDPOINT_HANDLE interopHandle, out PARTY_ENDPOINT_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
