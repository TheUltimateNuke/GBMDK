using System;

namespace PartyCSharpSDK
{
	public class PARTY_STATE_CHANGE
	{
		protected bool useObjectPool;

		public PARTY_STATE_CHANGE_TYPE StateChangeType { get; }

		internal IntPtr StateChangeId { get; }

		protected PARTY_STATE_CHANGE(PARTY_STATE_CHANGE_TYPE StateChangeType, IntPtr StateChangeId)
		{
		}

		internal static PARTY_STATE_CHANGE CreateFromPtr(IntPtr stateChangePtr)
		{
			return null;
		}

		internal virtual void Cleanup()
		{
		}
	}
}
