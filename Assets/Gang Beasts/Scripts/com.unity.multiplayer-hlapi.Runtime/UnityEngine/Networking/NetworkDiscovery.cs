using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[AddComponentMenu("Network/NetworkDiscovery")]
	[DisallowMultipleComponent]
	public class NetworkDiscovery : MonoBehaviour
	{
		private const int k_MaxBroadcastMsgSize = 1024;

		[SerializeField]
		private int m_BroadcastPort;

		[SerializeField]
		private int m_BroadcastKey;

		[SerializeField]
		private int m_BroadcastVersion;

		[SerializeField]
		private int m_BroadcastSubVersion;

		[SerializeField]
		private int m_BroadcastInterval;

		[SerializeField]
		private bool m_UseNetworkManager;

		[SerializeField]
		private string m_BroadcastData;

		[SerializeField]
		private bool m_ShowGUI;

		[SerializeField]
		private int m_OffsetX;

		[SerializeField]
		private int m_OffsetY;

		private int m_HostId;

		private bool m_Running;

		private bool m_IsServer;

		private bool m_IsClient;

		private byte[] m_MsgOutBuffer;

		private byte[] m_MsgInBuffer;

		private HostTopology m_DefaultTopology;

		private Dictionary<string, NetworkBroadcastResult> m_BroadcastsReceived;

		public int broadcastPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int broadcastKey
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int broadcastVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int broadcastSubVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int broadcastInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool useNetworkManager
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string broadcastData
		{
			get
			{
				return null;
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

		public int hostId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool running
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isServer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isClient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Dictionary<string, NetworkBroadcastResult> broadcastsReceived => null;

		private static byte[] StringToBytes(string str)
		{
			return null;
		}

		private static string BytesToString(byte[] bytes)
		{
			return null;
		}

		public bool Initialize()
		{
			return false;
		}

		public bool StartAsClient()
		{
			return false;
		}

		public bool StartAsServer()
		{
			return false;
		}

		public void StopBroadcast()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void OnReceivedBroadcast(string fromAddress, string data)
		{
		}

		private void OnGUI()
		{
		}
	}
}
