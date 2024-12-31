using System.Collections.Generic;
using Coatsink.Platform.Systems.Online.Connections;

namespace Coatsink.Platform.Steam
{
	public class P2PReaderFactory : INetReaderFactory
	{
		private readonly IDictionary<string, int> _channelCodes;

		public P2PReaderFactory(IDictionary<string, int> channelCodes)
		{
		}

		public INetReader CreateReader(string[] keys)
		{
			return null;
		}
	}
}
