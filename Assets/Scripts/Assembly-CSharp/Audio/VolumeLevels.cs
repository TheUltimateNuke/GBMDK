using UnityEngine;

namespace Audio
{
	public static class VolumeLevels
	{
		public enum SoundType
		{
			Override = 0,
			SFX = 1,
			Interface = 2,
			Vocal = 3,
			Ambience = 4
		}

		public static bool kMusicEnabled;

		public static float kMasterVolume;

		public static float kMusicVolume;

		public static float kAmbienceVolume;

		public static float kSFXVolume;

		public static float kVocalVolume;

		public static float kInterfaceVolume;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void Reset()
		{
		}
	}
}
