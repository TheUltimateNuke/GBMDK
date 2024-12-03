using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_HTTP_HEADER
	{
		public string name { get; }

		public string value { get; }

		internal PARTY_XBL_HTTP_HEADER(PartyXBLCSharpSDK.Interop.PARTY_XBL_HTTP_HEADER interopStruct)
		{
		}
	}
}
