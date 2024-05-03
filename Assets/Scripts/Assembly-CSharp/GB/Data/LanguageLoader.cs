using System;
using System.Runtime.CompilerServices;
using GB.Data.Language;
using GB.Data.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data
{
	public static class LanguageLoader
	{
		private static IDataCache _languageData;

		private static LanguageDatabase dataBase;

		private static int _activeLanguage;

		public static IDataCache Resources => null;

		public static int ActiveLanguage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private static string ActiveKey => null;

		public static int LanguageCount => 0;

		public static event Action OnLanguageChanged
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

		static LanguageLoader()
		{
		}

		public static void Initialise(string languageKeys = "Language")
		{
		}

		public static void Terminate()
		{
		}

		private static void OnLanguageCacheLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		private static void LoadLanguage()
		{
		}

		public static int SystemDirectLoad()
		{
			return 0;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static string GetLanguageKey(int index)
		{
			return null;
		}

		public static int GetSystemLanguage()
		{
			return 0;
		}
	}
}
