using System;
using System.Collections.Generic;
using GB.Data.Loading;
using GB.Networking.Utils.Spawn;
using UnityEngine;

namespace GB.Game.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "WavesData", menuName = "Gang Beasts/Data/Game/Waves Data", order = 1)]
	public class WavesData : ScriptableObject, IDataRegister
	{
		public const int DEFAULT_AI = 10;

		[SerializeField]
		public List<GameObject> beastTypePref;

		[SerializeField]
		public List<int> fallbackColourIndex;

		[SerializeField]
		public List<GBSpawnPoint.SpawnPointTypes> fallbackSpawnLocations;

		[SerializeField]
		public List<string> fallbackCostumes;

		[SerializeField]
		public List<Wave> levelWaves;

		[SerializeField]
		public string overCode;

		[SerializeField]
		public Color overColour;

		public int GetRandomColour()
		{
			return 0;
		}

		public int GetRandomSpawn()
		{
			return 0;
		}

		public string GetRandomCostume()
		{
			return null;
		}

		public GameObject GetSpawnObject(int type)
		{
			return null;
		}

		public void Register()
		{
		}

		public void Unregister()
		{
		}
	}
}
