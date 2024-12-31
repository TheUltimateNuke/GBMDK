using PartyCSharpSDK;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_ACCESSIBILITY_SETTINGS
	{
		public byte SpeechToTextEnabled { get; }

		public byte TextToSpeechEnabled { get; }

		public string LanguageCode { get; }

		public PARTY_GENDER Gender { get; }

		internal PARTY_XBL_ACCESSIBILITY_SETTINGS(PartyXBLCSharpSDK.Interop.PARTY_XBL_ACCESSIBILITY_SETTINGS interopStruct)
		{
		}
	}
}
