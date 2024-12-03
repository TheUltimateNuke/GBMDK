using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Networking
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkIdentity")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public sealed class NetworkIdentity : MonoBehaviour
	{
		public delegate void ClientAuthorityCallback(NetworkConnection conn, NetworkIdentity uv, bool authorityState);

		[SerializeField]
		private NetworkSceneId m_SceneId;

		[SerializeField]
		private NetworkHash128 m_AssetId;

		[SerializeField]
		private bool m_ServerOnly;

		[SerializeField]
		private bool m_LocalPlayerAuthority;

		private bool m_IsClient;

		private bool m_IsServer;

		private bool m_HasAuthority;

		private NetworkInstanceId m_NetId;

		private bool m_IsLocalPlayer;

		private NetworkConnection m_ConnectionToServer;

		private NetworkConnection m_ConnectionToClient;

		private short m_PlayerId;

		private NetworkBehaviour[] m_NetworkBehaviours;

		private HashSet<int> m_ObserverConnections;

		private List<NetworkConnection> m_Observers;

		private NetworkConnection m_ClientAuthorityOwner;

		private bool m_Reset;

		private static uint s_NextNetworkId;

		private static NetworkWriter s_UpdateWriter;

		public static ClientAuthorityCallback clientAuthorityCallback;

		public bool isClient => false;

		public bool isServer => false;

		public bool hasAuthority => false;

		public NetworkInstanceId netId => default(NetworkInstanceId);

		public NetworkSceneId sceneId => default(NetworkSceneId);

		public bool serverOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool localPlayerAuthority
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NetworkConnection clientAuthorityOwner => null;

		public NetworkHash128 assetId => default(NetworkHash128);

		public bool isLocalPlayer => false;

		public short playerControllerId => 0;

		public NetworkConnection connectionToServer => null;

		public NetworkConnection connectionToClient => null;

		public ReadOnlyCollection<NetworkConnection> observers => null;

		internal void SetDynamicAssetId(NetworkHash128 newAssetId)
		{
		}

		internal void SetClientOwner(NetworkConnection conn)
		{
		}

		internal void ClearClientOwner()
		{
		}

		internal void ForceAuthority(bool authority)
		{
		}

		internal static NetworkInstanceId GetNextNetworkId()
		{
			return default(NetworkInstanceId);
		}

		private void CacheBehaviours()
		{
		}

		internal static void AddNetworkId(uint id)
		{
		}

		internal void SetNetworkInstanceId(NetworkInstanceId newNetId)
		{
		}

		public void ForceSceneId(int newSceneId)
		{
		}

		internal void UpdateClientServer(bool isClientFlag, bool isServerFlag)
		{
		}

		internal void SetNotLocalPlayer()
		{
		}

		internal void RemoveObserverInternal(NetworkConnection conn)
		{
		}

		private void OnDestroy()
		{
		}

		internal void OnStartServer(bool allowNonZeroNetId)
		{
		}

		internal void OnStartClient()
		{
		}

		internal void OnStartAuthority()
		{
		}

		internal void OnStopAuthority()
		{
		}

		internal void OnSetLocalVisibility(bool vis)
		{
		}

		internal bool OnCheckObserver(NetworkConnection conn)
		{
			return false;
		}

		internal void UNetSerializeAllVars(NetworkWriter writer)
		{
		}

		internal void HandleClientAuthority(bool authority)
		{
		}

		private bool GetInvokeComponent(int cmdHash, Type invokeClass, out NetworkBehaviour invokeComponent)
		{
			invokeComponent = null;
			return false;
		}

		internal void HandleSyncEvent(int cmdHash, NetworkReader reader)
		{
		}

		internal void HandleSyncList(int cmdHash, NetworkReader reader)
		{
		}

		internal void HandleCommand(int cmdHash, NetworkReader reader)
		{
		}

		internal void HandleRPC(int cmdHash, NetworkReader reader)
		{
		}

		public void UNetUpdate()
		{
		}

		private NetworkBehaviour[] GetBehavioursOfSameChannel(int channelId, bool initialState)
		{
			return null;
		}

		internal void OnUpdateVars(NetworkReader reader, bool initialState, NetworkMessage netMsg)
		{
		}

		internal void SetLocalPlayer(short localPlayerControllerId)
		{
		}

		internal void SetConnectionToServer(NetworkConnection conn)
		{
		}

		internal void SetConnectionToClient(NetworkConnection conn, short newPlayerControllerId)
		{
		}

		internal void OnNetworkDestroy()
		{
		}

		internal void ClearObservers()
		{
		}

		internal void AddObserver(NetworkConnection conn)
		{
		}

		internal void RemoveObserver(NetworkConnection conn)
		{
		}

		public void RebuildObservers(bool initialize)
		{
		}

		public bool RemoveClientAuthority(NetworkConnection conn)
		{
			return false;
		}

		public bool AssignClientAuthority(NetworkConnection conn)
		{
			return false;
		}

		internal void MarkForReset()
		{
		}

		internal void Reset()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnRuntimeInitializeOnLoad()
		{
		}

		internal static void UNetStaticUpdate()
		{
		}
	}
}
