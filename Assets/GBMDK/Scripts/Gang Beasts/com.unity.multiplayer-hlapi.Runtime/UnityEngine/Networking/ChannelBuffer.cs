using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	internal class ChannelBuffer : IDisposable
	{
		private NetworkConnection m_Connection;

		private ChannelPacket m_CurrentPacket;

		private float m_LastFlushTime;

		private byte m_ChannelId;

		private int m_MaxPacketSize;

		private bool m_IsReliable;

		private bool m_AllowFragmentation;

		private bool m_IsBroken;

		private int m_MaxPendingPacketCount;

		private const int k_MaxFreePacketCount = 512;

		public const int MaxPendingPacketCount = 16;

		public const int MaxBufferedPackets = 512;

		private Queue<ChannelPacket> m_PendingPackets;

		private static List<ChannelPacket> s_FreePackets;

		internal static int pendingPacketCount;

		public float maxDelay;

		private float m_LastBufferedMessageCountTimer;

		private static NetworkWriter s_SendWriter;

		private static NetworkWriter s_FragmentWriter;

		private const int k_PacketHeaderReserveSize = 100;

		private bool m_Disposed;

		internal NetBuffer fragmentBuffer;

		private bool readingFragment;

		public int numMsgsOut { get; private set; }

		public int numBufferedMsgsOut { get; private set; }

		public int numBytesOut { get; private set; }

		public int numMsgsIn { get; private set; }

		public int numBytesIn { get; private set; }

		public int numBufferedPerSecond { get; private set; }

		public int lastBufferedPerSecond { get; private set; }

		public ChannelBuffer(NetworkConnection conn, int bufferSize, byte cid, bool isReliable, bool isSequenced)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public bool SetOption(ChannelOption option, int value)
		{
			return false;
		}

		public void CheckInternalBuffer()
		{
		}

		public bool SendWriter(NetworkWriter writer)
		{
			return false;
		}

		public bool Send(short msgType, MessageBase msg)
		{
			return false;
		}

		internal bool HandleFragment(NetworkReader reader)
		{
			return false;
		}

		internal bool SendFragmentBytes(byte[] bytes, int bytesToSend)
		{
			return false;
		}

		internal bool SendBytes(byte[] bytes, int bytesToSend)
		{
			return false;
		}

		private void QueuePacket()
		{
		}

		private ChannelPacket AllocPacket()
		{
			return default(ChannelPacket);
		}

		private static void FreePacket(ChannelPacket packet)
		{
		}

		public bool SendInternalBuffer()
		{
			return false;
		}
	}
}
