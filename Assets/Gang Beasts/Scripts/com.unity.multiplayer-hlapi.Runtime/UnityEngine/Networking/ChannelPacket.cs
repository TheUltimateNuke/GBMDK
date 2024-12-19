namespace UnityEngine.Networking
{
	internal struct ChannelPacket
	{
		private int m_Position;

		private byte[] m_Buffer;

		private bool m_IsReliable;

		public ChannelPacket(int packetSize, bool isReliable)
		{
			m_Position = 0;
			m_Buffer = null;
			m_IsReliable = false;
		}

		public void Reset()
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void Write(byte[] bytes, int numBytes)
		{
		}

		public bool HasSpace(int numBytes)
		{
			return false;
		}

		public bool SendToTransport(NetworkConnection conn, int channelId)
		{
			return false;
		}
	}
}
