using System;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Audio
{
	public static class AudioLoader
	{
		private static AudioDatabase _cachedAudioDatabaseBase;

		private static AsyncOperationHandle<AudioDatabase> _loader;

		private static AsyncOperationHandle<AudioDatabase> _lastLoader;

		public static event Action OnAudioLoaded
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

		public static void Initialise()
		{
		}

		private static void OnDatabaseLoaded(AsyncOperationHandle<AudioDatabase> obj)
		{
		}

		public static AudioDatabaseItem LoadAudio(string key)
		{
			return null;
		}
	}
}
