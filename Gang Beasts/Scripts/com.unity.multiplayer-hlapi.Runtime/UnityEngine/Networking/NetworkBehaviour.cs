using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(NetworkIdentity))]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkBehaviour : MonoBehaviour
	{
		public delegate void CmdDelegate(NetworkBehaviour obj, NetworkReader reader);

		protected delegate void EventDelegate(List<Delegate> targets, NetworkReader reader);

		protected enum UNetInvokeType
		{
			Command = 0,
			ClientRpc = 1,
			SyncEvent = 2,
			SyncList = 3
		}

		protected class Invoker
		{
			public UNetInvokeType invokeType;

			public Type invokeClass;

			public CmdDelegate invokeFunction;

			public string DebugString()
			{
				return null;
			}
		}

		private uint m_SyncVarDirtyBits;

		private float m_LastSendTime;

		private bool m_SyncVarGuard;

		private const float k_DefaultSendInterval = 0.1f;

		private NetworkIdentity m_MyView;

		private static Dictionary<int, Invoker> s_CmdHandlerDelegates;

		public bool localPlayerAuthority => false;

		public bool isServer => false;

		public bool isClient => false;

		public bool isLocalPlayer => false;

		public bool hasAuthority => false;

		public NetworkInstanceId netId => default(NetworkInstanceId);

		public NetworkConnection connectionToServer => null;

		public NetworkConnection connectionToClient => null;

		public short playerControllerId => 0;

		protected uint syncVarDirtyBits => 0u;

		protected bool syncVarHookGuard
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal NetworkIdentity netIdentity => null;

		private NetworkIdentity myView => null;

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendCommandInternal(NetworkWriter writer, int channelId, string cmdName)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeCommand(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendRPCInternal(NetworkWriter writer, int channelId, string rpcName)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendTargetRPCInternal(NetworkConnection conn, NetworkWriter writer, int channelId, string rpcName)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeRPC(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SendEventInternal(NetworkWriter writer, int channelId, string eventName)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeSyncEvent(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool InvokeSyncList(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterCommandDelegate(Type invokeClass, int cmdHash, CmdDelegate func)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterRpcDelegate(Type invokeClass, int cmdHash, CmdDelegate func)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterEventDelegate(Type invokeClass, int cmdHash, CmdDelegate func)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected static void RegisterSyncListDelegate(Type invokeClass, int cmdHash, CmdDelegate func)
		{
		}

		internal static string GetInvoker(int cmdHash)
		{
			return null;
		}

		internal static bool GetInvokerForHashCommand(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction)
		{
			invokeClass = null;
			invokeFunction = null;
			return false;
		}

		internal static bool GetInvokerForHashClientRpc(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction)
		{
			invokeClass = null;
			invokeFunction = null;
			return false;
		}

		internal static bool GetInvokerForHashSyncList(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction)
		{
			invokeClass = null;
			invokeFunction = null;
			return false;
		}

		internal static bool GetInvokerForHashSyncEvent(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction)
		{
			invokeClass = null;
			invokeFunction = null;
			return false;
		}

		private static bool GetInvokerForHash(int cmdHash, UNetInvokeType invokeType, out Type invokeClass, out CmdDelegate invokeFunction)
		{
			invokeClass = null;
			invokeFunction = null;
			return false;
		}

		internal static void DumpInvokers()
		{
		}

		internal bool ContainsCommandDelegate(int cmdHash)
		{
			return false;
		}

		internal bool InvokeCommandDelegate(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		internal bool InvokeRpcDelegate(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		internal bool InvokeSyncEventDelegate(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		internal bool InvokeSyncListDelegate(int cmdHash, NetworkReader reader)
		{
			return false;
		}

		internal static string GetCmdHashHandlerName(int cmdHash)
		{
			return null;
		}

		private static string GetCmdHashPrefixName(int cmdHash, string prefix)
		{
			return null;
		}

		internal static string GetCmdHashCmdName(int cmdHash)
		{
			return null;
		}

		internal static string GetCmdHashRpcName(int cmdHash)
		{
			return null;
		}

		internal static string GetCmdHashEventName(int cmdHash)
		{
			return null;
		}

		internal static string GetCmdHashListName(int cmdHash)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetSyncVarGameObject(GameObject newGameObject, ref GameObject gameObjectField, uint dirtyBit, ref NetworkInstanceId netIdField)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetSyncVar<T>(T value, ref T fieldValue, uint dirtyBit)
		{
		}

		public void SetDirtyBit(uint dirtyBit)
		{
		}

		public void ClearAllDirtyBits()
		{
		}

		internal int GetDirtyChannel()
		{
			return 0;
		}

		public virtual bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			return false;
		}

		public virtual void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void PreStartClient()
		{
		}

		public virtual void OnNetworkDestroy()
		{
		}

		public virtual void OnStartServer()
		{
		}

		public virtual void OnStartClient()
		{
		}

		public virtual void OnStartLocalPlayer()
		{
		}

		public virtual void OnStartAuthority()
		{
		}

		public virtual void OnStopAuthority()
		{
		}

		public virtual bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initialize)
		{
			return false;
		}

		public virtual void OnSetLocalVisibility(bool vis)
		{
		}

		public virtual bool OnCheckObserver(NetworkConnection conn)
		{
			return false;
		}

		public virtual int GetNetworkChannel()
		{
			return 0;
		}

		public virtual float GetNetworkSendInterval()
		{
			return 0f;
		}
	}
}
