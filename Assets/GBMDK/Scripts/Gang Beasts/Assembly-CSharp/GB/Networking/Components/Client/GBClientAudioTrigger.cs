using System.Runtime.CompilerServices;
using CoreNet.Components;
using CoreNet.Messaging;
using GB.Networking.Messaging.Messages;

namespace GB.Networking.Components.Client
{
	internal class GBClientAudioTrigger : NetComponent
	{
		public delegate void MessageEventDel(NetServerMessage message);

		public static event MessageEventDel OnMessageReceived
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

		private void Start()
		{
		}

		public static void FlushEvents()
		{
		}

		private NetMessenger.MessageCallback<NetServerMessage> OnServerMessageReceived()
		{
			return null;
		}
	}
}
