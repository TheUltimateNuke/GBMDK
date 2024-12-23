using CoreNet.Messaging.Messages;
using UnityEngine.Networking;

namespace CoreNet.Components.Server
{
	public class NetServerCatchUp : NetComponent
	{
		private new void Awake()
		{
		}

		private void OnCatchUpRequest(NetNullMessage message, NetworkConnection conn)
		{
		}
	}
}
