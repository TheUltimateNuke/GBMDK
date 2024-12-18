using System.Collections.Generic;

namespace UnityEngine.Networking
{
	internal sealed class LocalClient : NetworkClient
	{
		private struct InternalMsg
		{
			internal byte[] buffer;

			internal int channelId;
		}

		private const int k_InitialFreeMessagePoolSize = 64;

		private List<InternalMsg> m_InternalMsgs;

		private List<InternalMsg> m_InternalMsgs2;

		private Stack<InternalMsg> m_FreeMessages;

		private NetworkServer m_LocalServer;

		private bool m_Connected;

		private NetworkMessage s_InternalMessage;

		public override void Disconnect()
		{
		}

		internal void InternalConnectLocalServer(bool generateConnectMsg)
		{
		}

		internal override void Update()
		{
		}

		internal void AddLocalPlayer(PlayerController localPlayer)
		{
		}

		private void PostInternalMessage(byte[] buffer, int channelId)
		{
		}

		private void PostInternalMessage(short msgType)
		{
		}

		private void ProcessInternalMessages()
		{
		}

		internal void InvokeHandlerOnClient(short msgType, MessageBase msg, int channelId)
		{
		}

		internal void InvokeBytesOnClient(byte[] buffer, int channelId)
		{
		}
	}
}
