using System;
using System.Collections.Generic;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkMigrationManager")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkMigrationManager : MonoBehaviour
	{
		public enum SceneChangeOption
		{
			StayInOnlineScene = 0,
			SwitchToOfflineScene = 1
		}

		public struct PendingPlayerInfo
		{
			public NetworkInstanceId netId;

			public short playerControllerId;

			public GameObject obj;
		}

		public struct ConnectionPendingPlayers
		{
			public List<PendingPlayerInfo> players;
		}

		[SerializeField]
		private bool m_HostMigration;

		[SerializeField]
		private bool m_ShowGUI;

		[SerializeField]
		private int m_OffsetX;

		[SerializeField]
		private int m_OffsetY;

		private NetworkClient m_Client;

		private bool m_WaitingToBecomeNewHost;

		private bool m_WaitingReconnectToNewHost;

		private bool m_DisconnectedFromHost;

		private bool m_HostWasShutdown;

		private MatchInfo m_MatchInfo;

		private int m_OldServerConnectionId;

		private string m_NewHostAddress;

		private PeerInfoMessage m_NewHostInfo;

		private PeerListMessage m_PeerListMessage;

		private PeerInfoMessage[] m_Peers;

		private Dictionary<int, ConnectionPendingPlayers> m_PendingPlayers;

		public bool hostMigration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool showGUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int offsetX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int offsetY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public NetworkClient client => null;

		public bool waitingToBecomeNewHost
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool waitingReconnectToNewHost
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool disconnectedFromHost => false;

		public bool hostWasShutdown => false;

		public MatchInfo matchInfo => null;

		public int oldServerConnectionId => 0;

		public string newHostAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PeerInfoMessage[] peers => null;

		public Dictionary<int, ConnectionPendingPlayers> pendingPlayers => null;

		private void AddPendingPlayer(GameObject obj, int connectionId, NetworkInstanceId netId, short playerControllerId)
		{
		}

		private GameObject FindPendingPlayer(int connectionId, NetworkInstanceId netId, short playerControllerId)
		{
			return null;
		}

		private void RemovePendingPlayer(int connectionId)
		{
		}

		private void Start()
		{
		}

		public void Reset(int reconnectId)
		{
		}

		internal void AssignAuthorityCallback(NetworkConnection conn, NetworkIdentity uv, bool authorityState)
		{
		}

		public void Initialize(NetworkClient newClient, MatchInfo newMatchInfo)
		{
		}

		public void DisablePlayerObjects()
		{
		}

		public void SendPeerInfo()
		{
		}

		private void OnPeerClientAuthority(NetworkMessage netMsg)
		{
		}

		private void OnPeerInfo(NetworkMessage netMsg)
		{
		}

		private void OnServerReconnectPlayerMessage(NetworkMessage netMsg)
		{
		}

		public bool ReconnectObjectForConnection(NetworkConnection newConnection, GameObject oldObject, int oldConnectionId)
		{
			return false;
		}

		public bool ReconnectPlayerForConnection(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId)
		{
			return false;
		}

		public bool LostHostOnClient(NetworkConnection conn)
		{
			return false;
		}

		public void LostHostOnHost()
		{
		}

		public bool BecomeNewHost(int port)
		{
			return false;
		}

		protected virtual void OnClientDisconnectedFromHost(NetworkConnection conn, out SceneChangeOption sceneChange)
		{
			sceneChange = default(SceneChangeOption);
		}

		protected virtual void OnServerHostShutdown()
		{
		}

		protected virtual void OnServerReconnectPlayer(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId)
		{
		}

		protected virtual void OnServerReconnectPlayer(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId, NetworkReader extraMessageReader)
		{
		}

		protected virtual void OnServerReconnectObject(NetworkConnection newConnection, GameObject oldObject, int oldConnectionId)
		{
		}

		protected virtual void OnPeersUpdated(PeerListMessage peers)
		{
		}

		protected virtual void OnAuthorityUpdated(GameObject go, int connectionId, bool authorityState)
		{
		}

		public virtual bool FindNewHost(out PeerInfoMessage newHostInfo, out bool youAreNewHost)
		{
			newHostInfo = null;
			youAreNewHost = default(bool);
			return false;
		}

		private void OnGUIHost()
		{
		}

		private void OnGUIClient()
		{
		}

		private void OnGUI()
		{
		}
	}
}
