using System.Collections.Generic;
using CoreNet.Components;
using GB.Networking.Messages;
using GB.Networking.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Components.Server
{
	public class GBServerItemSpawner : NetComponent
	{
		private static readonly ulong[] DEVELOPER_IDS;

		private static int AI_CONTROLLER_STARTIDEX;

		private List<NetBeast> _aiNetPlayers;

		private new void Awake()
		{
		}

		private void ReceiveSpawnRequest(NetSpawnObjectMessage msg, NetworkConnection conn)
		{
		}

		private void ReceiveSpawnActorRequest(NetSpawnObjectMessage msg, NetworkConnection conn)
		{
		}

		public void CleanupSpawnedAI()
		{
		}

		private bool AuthenticateRequest(NetworkConnection conn)
		{
			return false;
		}
	}
}
