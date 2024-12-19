using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class KOSoundConfig
	{
		public float koSoundVolume;

		public AudioClip finalKOSound;

		[SerializeField]
		public List<AudioClip> KOSounds;
	}
}
