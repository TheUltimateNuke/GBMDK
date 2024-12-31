using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
	public class PlatformStatisticsDatabase : ScriptableObject, ISerializationCallbackReceiver
	{
		public enum StatsType
		{
			FLOAT = 0,
			INT = 1
		}

		[Serializable]
		public class StatisticInfo
		{
			[Serializable]
			public class AchievementLink
			{
				public string achievementKey;

				public float achievementUnlock;
			}

			public string key;

			public string name;

			public string description;

			public string steamAPI;

			public string xboxAPI;

			public string gogAPI;

			public StatsType statType;

			public List<AchievementLink> achievements;

			public bool achievementLinked => false;

			public StatisticInfo(string userKey)
			{
			}
		}

		public Dictionary<string, StatisticInfo> statistics;

		[NonSerialized]
		private string[] _keys;

		[NonSerialized]
		private string[] _xboxAPIs;

		[SerializeField]
		private int _estFileSize;

		[SerializeField]
		public string SystemStatsStorageLocation;

		[SerializeField]
		private List<StatisticInfo> _serializer;

		public string[] Keys => null;

		public string[] XboxAPIs => null;

		public int EstFileSize => 0;

		public string Name(string key)
		{
			return null;
		}

		public string Description(string key)
		{
			return null;
		}

		public string SteamAPI(string key)
		{
			return null;
		}

		public string GogAPI(string key)
		{
			return null;
		}

		public string XboxAPI(string key)
		{
			return null;
		}

		public StatsType Type(string key)
		{
			return default(StatsType);
		}

		public bool AchievementLinked(string key)
		{
			return false;
		}

		public string AchievementLink(string key, int index)
		{
			return null;
		}

		public float AchievementUnlock(string key, int index)
		{
			return 0f;
		}

		public string AchievementUnlockCheck(string key, float value, int index)
		{
			return null;
		}

		public string AchievementUnlock(string key, float value, Action<string> unlockCall)
		{
			return null;
		}

		public string AchievementUpdate(string key, float value, Action<string, float, float> update)
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
