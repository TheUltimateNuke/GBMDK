using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	public class JukeboxConfig : ScriptableObject
	{
		[SerializeField]
		public AudioMixer audioMixer;

		[SerializeField]
		public List<JukeboxTrack> jukeboxTracks;
	}
}
