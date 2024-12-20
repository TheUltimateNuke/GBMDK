using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Types
{
	[Serializable]
	public class ClientConnection
	{
		public NetworkConnection Connection;

		public List<ClientPlayer> PlayersOnThisConnection;

		public Coroutine ReadyTimeoutCoroutine;

		public bool loadedScene;

		public bool IsReady;

		public ClientConnection(NetworkConnection conn)
		{
		}

		public void AddClientPlayerInfo(int playerID, short controlID = -1)
		{
		}

		public bool RemoveClientPlayer(int playerID)
		{
			return false;
		}

		public bool RemoveClientPlayer(short controlID)
		{
			return false;
		}
	}
}
