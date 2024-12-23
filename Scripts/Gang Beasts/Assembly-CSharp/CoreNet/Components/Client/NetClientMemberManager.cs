using System.Runtime.CompilerServices;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Client
{
	public class NetClientMemberManager : NetComponent
	{
		public delegate void Handler();

		public static event Handler OnPasswordRequest
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

		public static void FlushEvent()
		{
		}

		protected new void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		private void OnRequestAuth(NetAuthRequestMessage message, NetworkConnection conn)
		{
		}

		private void RunPasswordAuth(NetAuthRequestMessage message)
		{
		}

		public void SendAuth(bool clientAuthPassed, string password = "")
		{
		}

		protected virtual NetAuthMessage CreateAuthMessage(bool clientAuthPassed, string password)
		{
			return null;
		}

		public void SendSetupComplete()
		{
		}

		protected virtual void OnRequestPlayers(NetNullMessage message, NetworkConnection conn)
		{
		}

		protected virtual void OnMemberAdded(NetMember member)
		{
		}

		protected virtual void OnMemberUpdated(NetMember member)
		{
		}

		protected virtual void OnMemberRemoved(NetMember member)
		{
		}

		protected virtual NetPlayersMessage<NetBeast> GetPlayersMessage()
		{
			return null;
		}
	}
}
