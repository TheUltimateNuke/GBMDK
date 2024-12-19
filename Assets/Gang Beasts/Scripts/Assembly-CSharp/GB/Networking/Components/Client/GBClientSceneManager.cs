using System.Runtime.CompilerServices;
using CoreNet.Components.Client;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Components.Client
{
	public class GBClientSceneManager : NetClientSceneManager
	{
		public delegate void StringHandler(string val);

		public delegate void ClientsLoadedDel(float val);

		public static event StringHandler OnNextSceneReceived
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

		public static event StringHandler OnNextModeReceived
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

		public static event ClientsLoadedDel OnClientSceneLoaded
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

		public static void FlushSceneListener()
		{
		}

		protected new void Awake()
		{
		}

		protected new void OnDestroy()
		{
		}

		private void OnNetMemberUpdated(NetMember item)
		{
		}

		private void ReceiveNextLevel(NetString Message, NetworkConnection conn)
		{
		}

		private void ReceiveNextMode(NetString Message, NetworkConnection conn)
		{
		}

		protected override void ForceReconnect()
		{
		}
	}
}
