using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Utils
{
	public class ConnectionStatus : MonoBehaviour
	{
		public enum Status
		{
			DISCONNECTED = 0,
			CLIENT_SPECTATOR = 1,
			CLIENT_PARTICIPANT = 2,
			SERVER = 3
		}

		public delegate void ConnectionStatusHandler(Status status);

		private static Status _CurrentStatus;

		public static Status CurrentStatus
		{
			get
			{
				return default(Status);
			}
			set
			{
			}
		}

		public static event ConnectionStatusHandler OnConnectionStatusUpdated
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

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnServerStarted()
		{
		}

		private void OnServerStopped()
		{
		}

		private void OnClientConnected(NetworkConnection conn)
		{
		}

		private void OnClientDisconnected(NetworkConnection conn)
		{
		}

		private void OnLocalPlayerSpawned()
		{
		}

		private void OnLocalPlayerDeath()
		{
		}
	}
}
