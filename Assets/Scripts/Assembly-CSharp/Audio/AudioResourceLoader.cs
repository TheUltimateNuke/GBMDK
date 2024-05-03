using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Core;
using GB.Setup;
using UnityEngine;

namespace Audio
{
	public class AudioResourceLoader : MonoBehaviour, IAsyncResourceLoader
	{
		[CompilerGenerated]
		private sealed class _003CLoadAudioConfigs_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioResourceLoader _003C_003E4__this;

			private LoadResourceTask<AudioConfig> _003CaudioConfigAsyncLoadRequest_003E5__2;

			private LoadResourceTask<JukeboxConfig> _003CjukeBoxAsyncLoadRequest_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CLoadAudioConfigs_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private const string AUDIO_CONFIG_ADDRESS = "Core/Audio/AudioConfig.asset";

		private const string AUDIO_JUKEBOX_ADDRESS = "Core/Audio/JukeboxConfig.asset";

		public static Action OnCurrentAudioDataChanged;

		private static AudioConfig _mapTracker;

		public static GlobalMusicConfig GlobalMusicData;

		public static TransitionTimes TransitionTimeData;

		public static UISoundConfig UISoundData;

		public static KOSoundConfig KOSoundConfig;

		public static SceneAudioConfig CurrentSceneAudioConfig;

		public static JukeboxConfig JukeboxData;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public bool HasCompletedLoading()
		{
			return false;
		}

		public void Awake()
		{
		}

		public void BeginAsyncLoading()
		{
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CLoadAudioConfigs_003Ed__15))]
		private IEnumerator LoadAudioConfigs()
		{
			return null;
		}

		public void OnDestroy()
		{
		}

		public static SceneAudioConfig GetLevelData()
		{
			return null;
		}

		public void LevelChanged()
		{
		}
	}
}
