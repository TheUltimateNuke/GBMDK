using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_LOCAL_USER_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_LOCAL_USER_HANDLE InteropHandle { get; set; }

		internal PARTY_LOCAL_USER_HANDLE(PartyCSharpSDK.Interop.PARTY_LOCAL_USER_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_LOCAL_USER_HANDLE interopHandle, out PARTY_LOCAL_USER_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
