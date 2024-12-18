using System;
using System.Collections.Generic;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[AddComponentMenu("Network/NetworkLobbyManager")]
	public class NetworkLobbyManager : NetworkManager
	{
		private struct PendingPlayer
		{
			public NetworkConnection conn;

			public GameObject lobbyPlayer;
		}

		[SerializeField]
		private bool m_ShowLobbyGUI;

		[SerializeField]
		private int m_MaxPlayers;

		[SerializeField]
		private int m_MaxPlayersPerConnection;

		[SerializeField]
		private int m_MinPlayers;

		[SerializeField]
		private NetworkLobbyPlayer m_LobbyPlayerPrefab;

		[SerializeField]
		private GameObject m_GamePlayerPrefab;

		[SerializeField]
		private string m_LobbyScene;

		[SerializeField]
		private string m_PlayScene;

		private List<PendingPlayer> m_PendingPlayers;

		public NetworkLobbyPlayer[] lobbySlots;

		private static LobbyReadyToBeginMessage s_ReadyToBeginMessage;

		private static IntegerMessage s_SceneLoadedMessage;

		private static LobbyReadyToBeginMessage s_LobbyReadyToBeginMessage;

		public bool showLobbyGUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int maxPlayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxPlayersPerConnection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int minPlayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public NetworkLobbyPlayer lobbyPlayerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject gamePlayerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string lobbyScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string playScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		private byte FindSlot()
		{
			return 0;
		}

		private void SceneLoadedForPlayer(NetworkConnection conn, GameObject lobbyPlayerGameObject)
		{
		}

		private static int CheckConnectionIsReadyToBegin(NetworkConnection conn)
		{
			return 0;
		}

		public void CheckReadyToBegin()
		{
		}

		public void ServerReturnToLobby()
		{
		}

		private void CallOnClientEnterLobby()
		{
		}

		private void CallOnClientExitLobby()
		{
		}

		public bool SendReturnToLobby()
		{
			return false;
		}

		public override void OnServerConnect(NetworkConnection conn)
		{
		}

		public override void OnServerDisconnect(NetworkConnection conn)
		{
		}

		public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
		{
		}

		public override void OnServerRemovePlayer(NetworkConnection conn, PlayerController player)
		{
		}

		public override void ServerChangeScene(string sceneName)
		{
		}

		public override void OnServerSceneChanged(string sceneName)
		{
		}

		private void OnServerReadyToBeginMessage(NetworkMessage netMsg)
		{
		}

		private void OnServerSceneLoadedMessage(NetworkMessage netMsg)
		{
		}

		private void OnServerReturnToLobbyMessage(NetworkMessage netMsg)
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnStartHost()
		{
		}

		public override void OnStopHost()
		{
		}

		public override void OnStartClient(NetworkClient lobbyClient)
		{
		}

		public override void OnClientConnect(NetworkConnection conn)
		{
		}

		public override void OnClientDisconnect(NetworkConnection conn)
		{
		}

		public override void OnStopClient()
		{
		}

		public override void OnClientSceneChanged(NetworkConnection conn)
		{
		}

		private void OnClientReadyToBegin(NetworkMessage netMsg)
		{
		}

		private void OnClientAddPlayerFailedMessage(NetworkMessage netMsg)
		{
		}

		public virtual void OnLobbyStartHost()
		{
		}

		public virtual void OnLobbyStopHost()
		{
		}

		public virtual void OnLobbyStartServer()
		{
		}

		public virtual void OnLobbyServerConnect(NetworkConnection conn)
		{
		}

		public virtual void OnLobbyServerDisconnect(NetworkConnection conn)
		{
		}

		public virtual void OnLobbyServerSceneChanged(string sceneName)
		{
		}

		public virtual GameObject OnLobbyServerCreateLobbyPlayer(NetworkConnection conn, short playerControllerId)
		{
			return null;
		}

		public virtual GameObject OnLobbyServerCreateGamePlayer(NetworkConnection conn, short playerControllerId)
		{
			return null;
		}

		public virtual void OnLobbyServerPlayerRemoved(NetworkConnection conn, short playerControllerId)
		{
		}

		public virtual bool OnLobbyServerSceneLoadedForPlayer(GameObject lobbyPlayer, GameObject gamePlayer)
		{
			return false;
		}

		public virtual void OnLobbyServerPlayersReady()
		{
		}

		public virtual void OnLobbyClientEnter()
		{
		}

		public virtual void OnLobbyClientExit()
		{
		}

		public virtual void OnLobbyClientConnect(NetworkConnection conn)
		{
		}

		public virtual void OnLobbyClientDisconnect(NetworkConnection conn)
		{
		}

		public virtual void OnLobbyStartClient(NetworkClient lobbyClient)
		{
		}

		public virtual void OnLobbyStopClient()
		{
		}

		public virtual void OnLobbyClientSceneChanged(NetworkConnection conn)
		{
		}

		public virtual void OnLobbyClientAddPlayerFailed()
		{
		}

		private void OnGUI()
		{
		}

		public void TryToAddPlayer()
		{
		}
	}
}
