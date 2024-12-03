using System;
using PartyXBLCSharpSDK.Interop;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_REQUIRED_CHAT_PERMISSION_INFO_CHANGED_STATE_CHANGE : PARTY_XBL_STATE_CHANGE
	{
		public PARTY_XBL_CHAT_USER_HANDLE localChatUser { get; }

		public PARTY_XBL_CHAT_USER_HANDLE targetChatUser { get; }

		internal PARTY_XBL_REQUIRED_CHAT_PERMISSION_INFO_CHANGED_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_XBL_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
