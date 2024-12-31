using System;
using Audio;
using UnityEngine;

namespace GB.Data.Audio
{
	[Serializable]
	public class AudioDatabaseItem
	{
		public AudioClip clip;

		public AudioMixerController.MixerGroup mixerGroup;

		public float volume;
	}
}
