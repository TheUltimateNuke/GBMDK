using System;
using System.Runtime.CompilerServices;
using GB.Data.Images;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data
{
	public static class ImageLoader
	{
		private static ImageDatabase _cachedImageDatabaseBase;

		private static ImageDatabase _cachedImageDatabaseLang;

		private static int _cachedPlatform;

		private static string _cachedLangauge;

		private static string IMAGE_DATABASE_FILE;

		private static AsyncOperationHandle<ImageDatabase> _loadingDefaultTask;

		private static AsyncOperationHandle<ImageDatabase> _loadingTask;

		private static AsyncOperationHandle<ImageDatabase> _loadingTaskLast;

		public static event Action OnImageLoaded
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

		public static void Initialise(string languageKey)
		{
		}

		private static void OnDefaultDataLoaded(AsyncOperationHandle<ImageDatabase> obj)
		{
		}

		private static void OnLanguageDataLoaded(AsyncOperationHandle<ImageDatabase> obj)
		{
		}

		public static Texture LoadImage(string key)
		{
			return null;
		}
	}
}
