using System.Collections.Generic;
using CoreNet.Components.Server;
using CoreNet.Utils;
using GB.Networking.Objects;
using GB.Networking.Utils.Spawn;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Networking.Components.Server
{
	public class GBServerSpawnManager : NetServerSpawnManager
	{
		public static string PATTERN_FILE;

		private static List<GBSpawnPoint> _spawnPoints;

		private SpawnPatternCarrier _spawnInfo;

		private SpawnPatternCarrier.Pattern _activePattern;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void Register(GBSpawnPoint point)
		{
		}

		public static void Unregister(GBSpawnPoint point)
		{
		}

		private new void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		public void PrepSpawnLayout(ref List<NetBeast> players)
		{
		}

		public override CoreNetSpawnPosition RetrieveSpawnPointForPlayer<T>(T player, SpawnParams parameters)
		{
			return null;
		}

		public override CoreNetSpawnPosition[] RetrieveAllSpawnPoints(SpawnParams parameters)
		{
			return null;
		}

		public static CoreNetSpawnPosition GetSpawnPoint<T>(T player, SpawnParams parameters)
		{
			return null;
		}

		public static IEnumerable<GBSpawnPoint> GetMatchingPoints(SpawnParams parameters, bool overrideFree, out GBSpawnPoint.SpawnPointTypes type)
		{
			type = default(GBSpawnPoint.SpawnPointTypes);
			return null;
		}
	}
}
