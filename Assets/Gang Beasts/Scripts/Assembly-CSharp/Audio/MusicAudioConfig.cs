using System;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class MusicAudioConfig
	{
		public float maxVolume;

		public AudioClip aSide;

		public AudioClip bSide;

		public AudioClip drums;

		public AudioClip warpA;

		public AudioClip warpB;

		public AudioClip ambience;
	}
}
