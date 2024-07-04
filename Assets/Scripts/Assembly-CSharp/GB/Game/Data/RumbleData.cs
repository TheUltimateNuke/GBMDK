using System;
using System.Collections.Generic;
using GB.Data.Loading;
using GB.Networking.Utils.Spawn;
using UnityEngine;

namespace GB.Game.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "RumbleData", menuName = "Gang Beasts/Data/Game/Rumble Data", order = 1)]
	public class RumbleData : ScriptableObject, IDataRegister
	{
		[SerializeField]
		public List<GameObject> beastTypePref;

		[SerializeField]
		public List<int> fallbackColourIndex;

		[SerializeField]
		public List<GBSpawnPoint.SpawnPointTypes> fallbackSpawnLocations;

		[SerializeField]
		public List<string> fallbackCostumes;

		[SerializeField]
		public float spawnTime;

		[SerializeField]
		public List<BeastSetup> beasts;

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
