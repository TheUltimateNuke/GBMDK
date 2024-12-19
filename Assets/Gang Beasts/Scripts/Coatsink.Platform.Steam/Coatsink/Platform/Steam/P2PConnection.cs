using Coatsink.Platform.Systems.Online.Connections;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class P2PConnection : BaseNetConnection
	{
		private readonly int[] _channels;

		private readonly bool[] _reliable;

		public static int MaxSendSize(EP2PSend type)
		{
			return 0;
		}

		public P2PConnection(int[] channels, bool[] reliable)
		{
		}

		public override uint SendTo(int channel, byte[] data, uint amount)
		{
			return 0u;
		}
	}
}
