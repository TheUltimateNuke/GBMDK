using System.Collections.Generic;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public static class NetworkManager
	{
		private static Dictionary<PlatformID, INetConnectionFactory> _connectionFactory;

		private static Dictionary<PlatformID, INetReaderFactory> _readerFactory;

		public static uint AddConnectionFactory(PlatformID platform, INetConnectionFactory factory)
		{
			return 0u;
		}

		public static INetConnection CreateConnection(PlatformID platform, string[] keys)
		{
			return null;
		}

		public static uint AddReaderFactory(PlatformID platform, INetReaderFactory factory)
		{
			return 0u;
		}

		public static INetReader CreateReader(PlatformID platform, string[] keys)
		{
			return null;
		}
	}
}
