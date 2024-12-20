using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_REMOTE_DEVICE_CREATED_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_DEVICE_HANDLE device { get; }

		internal PARTY_REMOTE_DEVICE_CREATED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}
