using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Unity.Collections;

namespace Unity.Ucg.Usqp
{
	internal class UsqpServer : IDisposable
	{
		private readonly Socket m_Socket;

		private NativeArray<byte> m_Buffer;

		private byte[] m_RecvBuffer;

		private Dictionary<EndPoint, uint> m_OutstandingTokens;

		private Random m_Random;

		private ServerInfo m_ServerInfo;

		private EndPoint m_RemoteEndpoint;

		public ServerInfo.Data ServerInfoData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IPEndPoint ServerEndpoint { get; }

		public UsqpServer(ushort port)
		{
		}

		public UsqpServer(IPEndPoint endpoint)
		{
		}

		public void Dispose()
		{
		}

		public void Update()
		{
		}

		private void PopPacketAndProcess(int read)
		{
		}

		private void SendChallengeResponse()
		{
		}

		private void SendQueryResponse(ref DataStreamReader reader)
		{
		}

		private uint GetNextToken()
		{
			return 0u;
		}
	}
}
