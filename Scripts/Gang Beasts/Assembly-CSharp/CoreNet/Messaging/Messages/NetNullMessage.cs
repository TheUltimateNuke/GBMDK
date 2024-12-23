using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetNullMessage : MessageBase
	{
		public static NetNullMessage CachedEmptyMessage => null;
	}
}
