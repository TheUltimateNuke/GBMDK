using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_HANDLE
	{
		internal PartyXBLCSharpSDK.Interop.PARTY_XBL_HANDLE InteropHandle { get; set; }

		public long GetHandleValue()
		{
			return 0L;
		}

		public PARTY_XBL_HANDLE(long handleValue)
		{
		}

		internal PARTY_XBL_HANDLE(PartyXBLCSharpSDK.Interop.PARTY_XBL_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyXBLCSharpSDK.Interop.PARTY_XBL_HANDLE interopHandle, out PARTY_XBL_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
