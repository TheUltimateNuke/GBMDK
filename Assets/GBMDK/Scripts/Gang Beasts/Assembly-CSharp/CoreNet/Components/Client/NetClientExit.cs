using System;
using System.Runtime.CompilerServices;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Client
{
	public class NetClientExit : NetComponent
	{
		public delegate void DisconnectHandler(string reason);

		private NetworkConnection _ServerConnection;

		private bool handlingForcedDisconnect;

		public static Action OnDisconnectOverride;

		public static event DisconnectHandler OnClientDisconnected
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

		public static void ForceClientDisconnectedEvent(string reason)
		{
		}

		private new void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnServerConnectionSet(NetConnection connection)
		{
		}

		public void OnExit(NetExitMessage message, NetworkConnection conn)
		{
		}
	}
}
