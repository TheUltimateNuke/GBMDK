using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct PeerInfoPlayer
	{
		public NetworkInstanceId netId;

		public short playerControllerId;
	}
}
