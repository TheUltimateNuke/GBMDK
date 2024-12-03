using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkBroadcastResult
	{
		public string serverAddress;

		public byte[] broadcastData;
	}
}
