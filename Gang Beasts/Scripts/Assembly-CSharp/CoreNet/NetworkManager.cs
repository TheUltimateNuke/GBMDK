using System.Runtime.CompilerServices;
using CoreNet.Config;
using CoreNet.Model;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet
{
	[RequireComponent(typeof(NetModel))]
	public class NetworkManager : UnityEngine.Networking.NetworkManager
	{
		public delegate void Handler();

		public delegate object ResourceGetter(string key);

		public static ServerConfig NetServerConfig;

		public static ResourceGetter LoadResource;

		private bool _clientConnectionCompleted;

		private NetModel _Model;

		public bool ClientConnecting => false;

		public static event Handler OnClientPreLoad
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

		public static event Handler OnClientStarted
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

		public static event Handler OnClientConnected
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

		public static event Handler OnClientStopped
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

		public static event Handler OnLocalClientStarted
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

		public static event Handler OnLocalClientStopped
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

		public static event Handler OnServerPreLoad
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

		public static event Handler OnServerStarted
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

		public static event Handler OnPreServerStopped
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

		public static event Handler OnServerStopped
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

		public static event Handler OnHostStarted
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

		public static event Handler OnHostStopped
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

		public static event Handler OnNetCleanup
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

		public static event Handler OnReadyUpdate
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

		public static event Handler OnConnectFailed
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

		protected override void OnLogSyncedMessage(string value)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void FlushAllEvents()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void DisconnectSelf()
		{
		}

		public void ForceDisconnectSelf()
		{
		}

		public void LaunchClient(string IP, int port)
		{
		}

		public void LaunchServer(ServerConfig config = null)
		{
		}

		public void LaunchHost()
		{
		}

		public void LaunchLocalClient()
		{
		}

		public override void OnClientSceneChanged(NetworkConnection conn)
		{
		}

		public override void OnStopClient()
		{
		}

		public override void OnStopServer()
		{
		}

		public override void OnClientConnect(NetworkConnection conn)
		{
		}

		public override void OnClientDisconnect(NetworkConnection conn)
		{
		}

		public override void OnServerConnect(NetworkConnection conn)
		{
		}

		public override void OnServerDisconnect(NetworkConnection conn)
		{
		}

		public override void OnServerReady(NetworkConnection conn)
		{
		}
	}
}
