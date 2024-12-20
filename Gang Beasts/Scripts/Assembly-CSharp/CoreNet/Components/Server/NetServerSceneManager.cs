using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Server
{
	public class NetServerSceneManager : NetComponent
	{
		public enum ServerLoadState
		{
			LoadingScene = 0,
			WaitingReservedConnection = 1,
			WaitingClientsLoad = 2,
			WaitingClietsReady = 3,
			Complete = 4
		}

		public delegate void OnClientLoadedScene(NetworkConnection conn, NetMember member);

		public int expectedNumPlayers;

		private NetworkManager _UNetManager;

		private ServerLoadState _loadState;

		private List<NetMember> _waitingCache;

		private float LOAD_TIME_MAX;

		private float READY_TIME_MAX;

		private float KICK_TIME_BOOST;

		private float timer;

		public ServerLoadState LoadState
		{
			get
			{
				return default(ServerLoadState);
			}
			protected set
			{
			}
		}

		public static event OnClientLoadedScene OnClientLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private new void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnNetMemberAdded(NetMember member)
		{
		}

		private void OnNetMemberUpdated(NetMember member)
		{
		}

		private void OnNetMemberRemoved(NetMember member)
		{
		}

		private void OnClientSceneLoaded(NetSceneMessage message, NetworkConnection conn)
		{
		}

		private void TrySetMemberLoaded(NetworkConnection conn, string scene)
		{
		}

		private void OnReadyUpdate()
		{
		}

		private void Update()
		{
		}

		public void DisconnectWaitingPlayers()
		{
		}

		private void OnSceneLoaded()
		{
		}

		public void ChangeScene(string sceneName)
		{
		}

		public void CheckState()
		{
		}

		private bool IsWaitingPlayerConnection()
		{
			return false;
		}

		private bool IsWaitingPlayersReady(ref List<NetMember> waitingList)
		{
			return false;
		}

		private bool IsWaitingClientLoads(ref List<NetMember> waitingList)
		{
			return false;
		}
	}
}
