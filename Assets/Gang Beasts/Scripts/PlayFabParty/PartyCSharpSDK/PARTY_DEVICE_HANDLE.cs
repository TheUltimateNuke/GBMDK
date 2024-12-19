using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_DEVICE_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_DEVICE_HANDLE InteropHandle { get; set; }

		internal PARTY_DEVICE_HANDLE(PartyCSharpSDK.Interop.PARTY_DEVICE_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_DEVICE_HANDLE interopHandle, out PARTY_DEVICE_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
