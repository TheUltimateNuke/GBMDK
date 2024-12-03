namespace UnityEngine.Networking
{
	internal class ULocalConnectionToServer : NetworkConnection
	{
		private NetworkServer m_LocalServer;

		public ULocalConnectionToServer(NetworkServer localServer)
		{
		}

		public override bool Send(short msgType, MessageBase msg)
		{
			return false;
		}

		public override bool SendUnreliable(short msgType, MessageBase msg)
		{
			return false;
		}

		public override bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public override bool SendBytes(byte[] bytes, int numBytes, int channelId)
		{
			return false;
		}

		public override bool SendWriter(NetworkWriter writer, int channelId)
		{
			return false;
		}

		public override void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = default(int);
			numBufferedMsgs = default(int);
			numBytes = default(int);
			lastBufferedPerSecond = default(int);
		}

		public override void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = default(int);
			numBytes = default(int);
		}
	}
}
