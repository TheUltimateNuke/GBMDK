using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	public class AudioMixerController : MonoBehaviour
	{
		public enum MixerTypes
		{
			Game = 0,
			Jukebox = 1
		}

		public enum MixerGroup
		{
			None = 0,
			ASide = 1,
			BSide = 2,
			Drums = 3,
			Warp = 4,
			Pause = 5,
			Ambience = 6,
			Voices = 7,
			Interface = 8,
			SFX = 9
		}

		public enum MixerSnapshot
		{
			None = 0,
			ASide = 1,
			BSide = 2,
			Drums = 3
		}

		private struct MixerData
		{
			public Dictionary<int, AudioMixerGroup> audioMixerGroups;

			public Dictionary<int, AudioMixerSnapshot> audioMixerSnapshots;
		}

		private static Dictionary<int, MixerData> audioMixerTypeData;

		private static MixerSnapshot _activeSnapshot;

		private static AudioMixerController _instance;

		public static MixerSnapshot ActiveSnapshot => default(MixerSnapshot);

		public static AudioMixerController Instance => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnAudioChanged()
		{
		}

		public void LoadAudioMixerGroups()
		{
		}

		private void LoadGroupsForMixer(AudioMixer mixer, ref MixerData data)
		{
		}

		public AudioMixerGroup GetMixerGroup(MixerGroup group, MixerTypes type = MixerTypes.Game)
		{
			return null;
		}

		private void LoadMixerSnapshots()
		{
		}

		private void LoadSnapshotsForMixer(AudioMixer mixer, ref MixerData data)
		{
		}

		public void TransitionToSnapshot(MixerSnapshot snapshot, float transitionTime = 1f, MixerTypes type = MixerTypes.Game)
		{
		}

		private void UnloadAllMixerData()
		{
		}
	}
}
