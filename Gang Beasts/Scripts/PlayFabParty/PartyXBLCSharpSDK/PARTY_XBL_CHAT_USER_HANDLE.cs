using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_CHAT_USER_HANDLE
	{
		internal PartyXBLCSharpSDK.Interop.PARTY_XBL_CHAT_USER_HANDLE InteropHandle { get; set; }

		internal PARTY_XBL_CHAT_USER_HANDLE(PartyXBLCSharpSDK.Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyXBLCSharpSDK.Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle, out PARTY_XBL_CHAT_USER_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
