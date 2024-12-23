using System.Collections.Generic;
using Coatsink.Platform.Systems.Online.Connections;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class P2PConnectionFactory : INetConnectionFactory
	{
		private readonly IDictionary<string, int> _channelCodes;

		private readonly IDictionary<string, bool> _reliableCodes;

		private Callback<P2PSessionConnectFail_t> _callbackOnP2PSessionConnectFail;

		public P2PConnectionFactory(IDictionary<string, int> channelCodes, IDictionary<string, bool> reliableCodes)
		{
		}

		~P2PConnectionFactory()
		{
		}

		protected void OnP2PSessionConnectFail(P2PSessionConnectFail_t message)
		{
		}

		public INetConnection CreateConnection(string[] keys)
		{
			return null;
		}
	}
}
