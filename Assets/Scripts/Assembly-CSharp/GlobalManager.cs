using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game;
using GB.UI.Menu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadAudioLevelsRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float fadeTime;

		public float masterVal;

		public float musicVal;

		public float ambienceVal;

		public float sfxVal;

		public float vocalVal;

		public float interfaceVal;

		public GlobalManager _003C_003E4__this;

		public float initialFadeValueOverride;

		private float _003CinitialMaster_003E5__2;

		private float _003CinitialMusic_003E5__3;

		private float _003CinitialAmbience_003E5__4;

		private float _003CinitialSFX_003E5__5;

		private float _003CinitialVocal_003E5__6;

		private float _003CinitialInterface_003E5__7;

		private float _003Cseconds_003E5__8;

		private float _003Ctime_003E5__9;

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

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CLoadAudioLevelsRoutine_003Ed__27(int _003C_003E1__state)
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

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	[CompilerGenerated]
	private sealed class _003CActionWrapper_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action a;

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

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CActionWrapper_003Ed__33(int _003C_003E1__state)
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

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private static GlobalManager _instance;

	private static object _lock;

	private static Queue<Action> _executionQueue;

	private bool _canTimeForce;

	[SerializeField]
	private TimeManager _timeManager;

	public DebugManager DebugManager;

	public PauseManager PauseManager;

	public CursorManagement cursorManager;

	public List<Actor> Actors;

	public string DefaultGamemodeID;

	public bool disableActors;

	public bool GameInProgress;

	public bool paused;

	private PlayerPool playerPool;

	public bool statusBars;

	public bool hideUI;

	public AnimationCurve audioFadeInCurve;

	private Coroutine loadAudioLevels;

	public float audioLoadFadeInDuration;

	private bool firstLoad;

	public static GlobalManager I => null;

	public TimeManager TimeManager => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAudioLevelsRoutine_003Ed__27))]
	public IEnumerator LoadAudioLevelsRoutine(float masterVal, float musicVal, float ambienceVal, float sfxVal, float vocalVal, float interfaceVal, float fadeTime, float initialFadeValueOverride = -1f)
	{
		return null;
	}

	private void LoadPrefs()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Enqueue(IEnumerator action)
	{
	}

	public void Enqueue(Action action)
	{
	}

	[IteratorStateMachine(typeof(_003CActionWrapper_003Ed__33))]
	private IEnumerator ActionWrapper(Action a)
	{
		return null;
	}

	private void Update()
	{
	}

	private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	public void SavePrefs()
	{
	}

	public void StopGame()
	{
	}
}
