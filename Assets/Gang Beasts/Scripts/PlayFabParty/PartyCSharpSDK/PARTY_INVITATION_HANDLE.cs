using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_INVITATION_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_INVITATION_HANDLE InteropHandle { get; set; }

		internal PARTY_INVITATION_HANDLE(PartyCSharpSDK.Interop.PARTY_INVITATION_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_INVITATION_HANDLE interopHandle, out PARTY_INVITATION_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
