using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_CREATE_ENDPOINT_COMPLETED_STATE_CHANGE : PARTY_STATE_CHANGE
	{
		public PARTY_STATE_CHANGE_RESULT result { get; }

		public uint errorDetail { get; }

		public PARTY_NETWORK_HANDLE network { get; }

		public PARTY_LOCAL_USER_HANDLE localUser { get; }

		public object asyncIdentifier { get; }

		public PARTY_ENDPOINT_HANDLE localEndpoint { get; }

		internal PARTY_CREATE_ENDPOINT_COMPLETED_STATE_CHANGE(PARTY_STATE_CHANGE_UNION stateChange, IntPtr StateChangeId)
			: base(default(PARTY_STATE_CHANGE_TYPE), (IntPtr)0)
		{
		}
	}
}