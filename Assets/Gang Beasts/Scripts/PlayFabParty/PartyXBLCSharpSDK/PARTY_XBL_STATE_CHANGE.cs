using System;

namespace PartyXBLCSharpSDK
{
	public class PARTY_XBL_STATE_CHANGE
	{
		public PARTY_XBL_STATE_CHANGE_TYPE StateChangeType { get; }

		internal IntPtr StateChangeId { get; }

		protected PARTY_XBL_STATE_CHANGE(PARTY_XBL_STATE_CHANGE_TYPE StateChangeType, IntPtr StateChangeId)
		{
		}

		internal static PARTY_XBL_STATE_CHANGE CreateFromPtr(IntPtr stateChangePtr)
		{
			return null;
		}
	}
}
