using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data
{
	public static class StringLoader
	{
		private static Dictionary<string, JSONObject> m_CoreJsonFile;

		private static string _cachedLangauge;

		private const int _maxArgs = 10;

		private static string[] _args;

		private static StringBuilder ms_PlatformStringBuilder;

		private const string SwitchConventionalPostfix = "_SWITCH";

		private static AsyncOperationHandle<TextAsset> _loadingTask;

		private static Dictionary<string, JSONObject> CoreJsonFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnLanguageLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private static bool GetLanguage(string language, out JSONObject languageJSON, Action OnLoad = null)
		{
			languageJSON = null;
			return false;
		}

		private static void LoadLanguage(string languageKey, Action OnLoad = null)
		{
		}

		public static void Initialise(string languageKey)
		{
		}

		private static void OnLanguageDataLoaded(string key, AsyncOperationHandle<TextAsset> obj)
		{
		}

		public static string LoadString(string key, string language_key = "")
		{
			return null;
		}

		public static string LoadRawString(string key, string language_key = "")
		{
			return null;
		}

		private static bool TryLoadStringByPlatform(JSONObject language, ref string pulledString, string key)
		{
			return false;
		}
	}
}
