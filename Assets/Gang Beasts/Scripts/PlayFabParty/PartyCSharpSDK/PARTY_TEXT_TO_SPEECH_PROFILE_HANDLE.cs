using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE
	{
		internal PartyCSharpSDK.Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE InteropHandle { get; set; }

		internal PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE(PartyCSharpSDK.Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE interopHandle)
		{
		}

		internal static uint WrapAndReturnError(uint error, PartyCSharpSDK.Interop.PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE interopHandle, out PARTY_TEXT_TO_SPEECH_PROFILE_HANDLE handle)
		{
			handle = null;
			return 0u;
		}

		internal void ClearInteropHandle()
		{
		}
	}
}
