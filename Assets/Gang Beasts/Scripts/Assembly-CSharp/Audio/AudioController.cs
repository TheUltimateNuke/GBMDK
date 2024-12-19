using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace Audio
{
	public class AudioController : MonoBehaviour
	{
		public class PooledAudioSource
		{
			public AudioSource audioSource;

			public Transform transform;

			public Transform target;

			public Action onComplete;

			public float volume;

			public VolumeLevels.SoundType type;

			public float timePlayed;

			public MeshRenderer debugMeshRenderer;

			public float delay;

			public string clipName;

			public float nameDisplayTimer;
		}

		public class PooledAudioTrack
		{
			public AudioSource audioSource;

			public Transform transform;

			public float maxVolume;

			public AnimFloat animVolume;
		}

		private static int kPoolSize;

		private int pooledSourceIndex;

		private PooledAudioSource[] _pooledSources;

		private AnimFloat _globalFadeVolume;

		private AnimFloat _SFXChannelFadeVolume;

		private AnimFloat _InterfaceChannelFadeVolume;

		private AnimFloat _VocalChannelFadeVolume;

		private PooledAudioTrack[] _pooledTracks;

		private const AudioRolloffMode defaultRolloffMode = AudioRolloffMode.Logarithmic;

		private const float defaultMaxDistance = 150f;

		public Mesh debugMesh;

		private AudioMixerGroup _ambienceAudioMixerGroup;

		private static AudioController _instance;

		public static int kNumMusicTracks { get; private set; }

		public static int kNumAmbienceTracks { get; private set; }

		private AudioMixerGroup AmbienceAudioMixerGroup => null;

		public static AudioController Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		public void EnableDebugRender(bool enable)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSceneChange(Scene scene, LoadSceneMode mode)
		{
		}

		private void Update()
		{
		}

		public void Play2D(AudioClip clip, VolumeLevels.SoundType soundType = VolumeLevels.SoundType.SFX, Action onComplete = null, bool loop = false, float volume = 1f, float pitch = 1f, float delay = 0f, AudioMixerGroup mixerGroup = null, PooledAudioSource pooledSource = null)
		{
		}

		public PooledAudioSource Play3DAt(AudioClip clip, Transform target, VolumeLevels.SoundType soundType = VolumeLevels.SoundType.SFX, Action onComplete = null, bool loop = false, float volume = 1f, float pitch = 1f, float delay = 0f, float minDistance = 1f, float maxDistance = 500f, float dopplerLevel = 0f, AudioMixerGroup mixerGroup = null, PooledAudioSource pooledSource = null, float spatialBlendOverride = 1f)
		{
			return null;
		}

		public PooledAudioSource Play3DAt(AudioClip clip, Vector3 location, Transform target = null, VolumeLevels.SoundType soundType = VolumeLevels.SoundType.SFX, Action onComplete = null, bool loop = false, float volume = 1f, float pitch = 1f, float delay = 0f, float minDistance = 1f, float maxDistance = 500f, float dopplerLevel = 0f, AudioMixerGroup mixerGroup = null, PooledAudioSource pooledSource = null, float spatialBlendOverride = 1f)
		{
			return null;
		}

		public void StopClip(AudioClip clip)
		{
		}

		public void SetAudiosourceVolume(VolumeLevels.SoundType soundType, float volume, AudioSource source)
		{
		}

		public AudioSource PlayMusic(AudioClip clip, float fadeInTime, int trackNumber, bool loop = false, float volume = 1f, AudioMixerGroup mixerGroup = null, Action OnTrackSwitch = null, float fadeOutTime = -1f, float minDistance = 10f, float maxDistance = 500f)
		{
			return null;
		}

		public AudioSource PlayMusic(AudioClip clip, float fadeInTime, int trackNumber, AudioMixerGroup mixerGroup, bool loop = false, float volume = 1f, Action OnTrackSwitch = null, float fadeOutTime = -1f, float minDistance = 10f, float maxDistance = 500f)
		{
			return null;
		}

		public void StopMusic(int trackNumber, float fadeTime)
		{
		}

		public void ChangeMusicVolume(int trackNumber, float volume, float fadeTime)
		{
		}

		public void PauseMusic(int trackNumber, float fadeTime)
		{
		}

		public void ResumeMusic(int trackNumber, float fadeTime)
		{
		}

		public bool IsMusicPlaying(int trackNumber)
		{
			return false;
		}

		public AudioSource GetTrackAudioSource(int trackNumber)
		{
			return null;
		}

		public void MoveMusicTrackToTransform(int trackNumber, Transform t)
		{
		}

		public AudioSource PlayAmbience(AudioClip clip, float fadeInTime, int trackNumber, bool loop = false, float volume = 1f, AudioMixerGroup mixerGroup = null, float fadeOutTime = -1f, float minDistance = 10f, float maxDistance = 500f)
		{
			return null;
		}

		public void PlayAmbience(AudioClip clip, float fadeInTime, int trackNumber, AudioMixerGroup mixerGroup, bool loop = false, float volume = 1f, float fadeOutTime = -1f, float minDistance = 10f, float maxDistance = 500f)
		{
		}

		public void StopAmbience(int trackNumber, float fadeTime)
		{
		}

		public void ChangeAmbienceVolume(int trackNumber, float volume, float fadeTime)
		{
		}

		public void PauseAmbience(int trackNumber, float fadeTime)
		{
		}

		public void ResumeAmbience(int trackNumber, float fadeTime)
		{
		}

		public bool IsAmbiencePlaying(int trackNumber)
		{
			return false;
		}

		public void MoveAmbienceTrackToTransform(int trackNumber, Transform t)
		{
		}

		public void FadeOutAllAudio(float fadeOutTime)
		{
		}

		public void FadeInAllAudio(float fadeInTime)
		{
		}

		public void FadeOutChannels(float fadeOutTime, params VolumeLevels.SoundType[] channels)
		{
		}

		public void FadeInChannels(float fadeOutTime, params VolumeLevels.SoundType[] channels)
		{
		}

		private bool ValidateMusicTrackNumber(int trackNumber)
		{
			return false;
		}

		private bool ValidateAmbienceTrackNumber(int trackNumber)
		{
			return false;
		}

		public PooledAudioSource GetSource()
		{
			return null;
		}

		private AudioSource PlayOnTrack(AudioClip clip, float fadeInTime, int trackNumber, bool loop = false, float volume = 1f, float minDistance = 10f, float maxDistance = 500f, AudioMixerGroup mixerGroup = null, Action OnTrackSwitch = null, float fadeOutTime = -1f)
		{
			return null;
		}

		private void StopTrack(int trackNumber, float fadeTime)
		{
		}

		private void ChangeTrackVolume(int trackNumber, float volume, float fadeTime)
		{
		}

		private bool IsTrackPlaying(int trackNumber)
		{
			return false;
		}

		private void PauseTrack(int trackNumber, float fadeTime)
		{
		}

		private void ResumeTrack(int trackNumber, float fadeTime)
		{
		}

		private void ResetSource(PooledAudioSource pSource)
		{
		}

		private void ResetTrack(PooledAudioTrack pTrack)
		{
		}
	}
}
