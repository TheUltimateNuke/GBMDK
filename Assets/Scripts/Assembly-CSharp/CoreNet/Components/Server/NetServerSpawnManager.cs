using CoreNet.Objects;
using CoreNet.Utils;

namespace CoreNet.Components.Server
{
	public abstract class NetServerSpawnManager : NetComponent
	{
		public abstract CoreNetSpawnPosition RetrieveSpawnPointForPlayer<T>(T player, SpawnParams parameters) where T : NetPlayer;

		public abstract CoreNetSpawnPosition[] RetrieveAllSpawnPoints(SpawnParams parameters);
	}
}
