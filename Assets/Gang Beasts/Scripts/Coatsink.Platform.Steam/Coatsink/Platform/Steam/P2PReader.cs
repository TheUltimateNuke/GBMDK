using System.Net;
using Coatsink.Platform.Systems.Online.Connections;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Steam
{
	public class P2PReader : INetReader
	{
		private readonly int[] _channels;

		public P2PReader(int[] channels)
		{
		}

		public uint Receive(out UserInfo sender, out EndPoint senderEnd, out int channel, byte[] data, int dataMax, out int received)
		{
			sender = default(UserInfo);
			senderEnd = null;
			channel = default(int);
			received = default(int);
			return 0u;
		}

		public uint Shutdown()
		{
			return 0u;
		}
	}
}
