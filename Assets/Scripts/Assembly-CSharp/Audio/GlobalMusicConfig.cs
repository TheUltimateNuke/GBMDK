using System;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class GlobalMusicConfig
	{
		public AudioClip pauseMusic;

		public AudioClip loadingMusic;

		public AudioClip audioSettingsModified;

		public float audioSettingsModifiedVolume;

		public float warpVolume;
	}
}
