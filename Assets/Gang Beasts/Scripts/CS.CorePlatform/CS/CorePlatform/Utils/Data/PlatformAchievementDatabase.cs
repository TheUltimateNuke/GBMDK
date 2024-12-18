using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
	public class PlatformAchievementDatabase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public class AchievementInfo
		{
			public string key;

			public string name;

			public string description;

			public int ps4Index;

			public string steamAPI;

			public string oculusAPI;

			public string xboxAPI;

			public string gogAPI;

			public AchievementInfo(string newKey)
			{
			}
		}

		public Dictionary<string, AchievementInfo> achievements;

		[SerializeField]
		private List<AchievementInfo> _serializer;

		public int PS4Index(string key)
		{
			return 0;
		}

		public string SteamAPI(string key)
		{
			return null;
		}

		public string OculusAPI(string key)
		{
			return null;
		}

		public string Name(string key)
		{
			return null;
		}

		public string Description(string key)
		{
			return null;
		}

		public int LargesPS4()
		{
			return 0;
		}

		public string XboxAPI(string key)
		{
			return null;
		}

		public string GOGAPI(string key)
		{
			return null;
		}

		public Dictionary<string, string> DictionaryListXbox()
		{
			return null;
		}

		public Dictionary<string, string> DictionaryListSteam()
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
