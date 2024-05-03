using CoreNet.Components;
using GB.Networking.Messages;
using UnityEngine.Networking;

namespace GB.Networking.Components.Server
{
	public class GBServerItemSpawner : NetComponent
	{
		private static readonly ulong[] DEVELOPER_IDS;

		private new void Awake()
		{
		}

		private void ReceiveSpawnRequest(NetSpawnObjectMessage msg, NetworkConnection conn)
		{
		}

		private void ReceiveSpawnActorRequest(NetSpawnObjectMessage msg, NetworkConnection conn)
		{
		}

		private bool AuthenticateRequest(NetworkConnection conn)
		{
			return false;
		}
	}
}
