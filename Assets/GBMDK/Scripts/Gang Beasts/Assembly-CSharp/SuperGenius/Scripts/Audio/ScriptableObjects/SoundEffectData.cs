using System;
using UnityEngine;

namespace SuperGenius.Scripts.Audio.ScriptableObjects
{
	[Serializable]
	public class SoundEffectData
	{
		public AudioClip[] AudioClips;

		[SerializeField]
		public float Volume;

		[SerializeField]
		[Tooltip("Random Between Volume +- VolumeRandomOffset")]
		public float VolumeRandomOffset;

		[SerializeField]
		public float Pitch;

		[Tooltip("Random Between Pitch +- PitchRandomOffset")]
		[SerializeField]
		public float PitchRandomOffset;

		public float MaxDistance;

		public float RandomVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RandomPitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AudioClip RandomAudioClip()
		{
			return null;
		}

		public virtual void Play(Vector3 position, Transform transform)
		{
		}

		private float GetOffset(float value, float range)
		{
			return 0f;
		}
	}
}
