using System;
using System.Runtime.CompilerServices;
using CoreNet.Messaging.Messages;
using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Client
{
	public class NetClientCatchUp : NetComponent
	{
		private bool _catchingUp;

		public bool CatchingUp => false;

		public static event Action OnModelCatchupComplete
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

		private void OnDestroy()
		{
		}

		private void OnServerConnectionSet(NetConnection connection)
		{
		}

		private void OnClientConnectionUpdated(NetConnection connection)
		{
		}

		private void OnClientConnectionRemoved(NetConnection connection)
		{
		}

		private void CatchUpToServerModel()
		{
		}

		private void OnMessageLockQueueCheck(NetModel.QueueCheck obj)
		{
		}

		private void OnCatchUpComplete(NetNullMessage message, NetworkConnection conn)
		{
		}
	}
}
