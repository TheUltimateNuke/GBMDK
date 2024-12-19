using PartyCSharpSDK;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_CHAT_PERMISSION_INFO
	{
		public PARTY_CHAT_PERMISSION_OPTIONS ChatPermissionMask { get; }

		public PARTY_XBL_CHAT_PERMISSION_MASK_REASON Reason { get; }

		internal PARTY_XBL_CHAT_PERMISSION_INFO(PartyXBLCSharpSDK.Interop.PARTY_XBL_CHAT_PERMISSION_INFO interopStruct)
		{
		}
	}
}
