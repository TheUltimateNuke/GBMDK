using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Serializable]
	[CreateAssetMenu(fileName = "SceneAudioConfig", menuName = "Gang Beasts/Data/Scene Audio Config", order = 1)]
	public class SceneAudioConfig : ScriptableObject
	{
		[SerializeField]
		public AudioMixer audioMixer;

		[SerializeField]
		public MusicAudioConfig musicData;
	}
}
