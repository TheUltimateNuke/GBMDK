using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_HANDLE InteropHandle { get; set; }

		public long GetHandleValue()
		{
			return 0L;
		}

		public PARTY_HANDLE(long handleValue)
		{
		}

		internal PARTY_HANDLE(PartyCSharpSDK.Interop.PARTY_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_HANDLE interopHandle, out PARTY_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
