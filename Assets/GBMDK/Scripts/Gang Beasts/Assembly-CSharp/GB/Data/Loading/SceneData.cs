using System;
using Audio;
using GB.Game.Data;
using GB.Networking.Utils.Spawn;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	[CreateAssetMenu(fileName = "SceneData", menuName = "Gang Beasts/Data/Scene Data", order = 1)]
	public class SceneData : ScriptableObject, ILoadedAsset, ICompleteTracker
	{
		public AssetReference _sceneRef;

		[SerializeField]
		private SpawnList _spawnList;

		[SerializeField]
		private SpawnPatternCarrier _spawnPattern;

		[SerializeField]
		private SceneAudioConfig _audioConfig;

		[SerializeField]
		private WavesData _wavesData;

		[SerializeField]
		private RumbleData _rumbleData;

		[SerializeField]
		private FootballData _footballData;

		[SerializeField]
		private CaptureTheFlagData _captureTheFlagData;

		[SerializeField]
		private KingOfTheHillData _kingOfTheHillData;

		[SerializeField]
		private AssetReference _overridesRef;

		private IDataCache _overrideData;

		private bool _loading;

		private bool _loaded;

		private Action _onCompleted;

		private Action _onGameModeCompleted;

		private ICompleteTracker _overrideLoad;

		public SceneAudioConfig AudioConfig => null;

		public WavesData WavesData => null;

		public RumbleData RumbleData => null;

		public FootballData FootballData => null;

		public CaptureTheFlagData CaptureTheFlagData => null;

		public KingOfTheHillData KingOfTheHillData => null;

		public AssetReference OverridesRef => null;

		public IDataCache Overrides => null;

		public AssetReference SceneRef => null;

		public SpawnList SpawnList => null;

		public SpawnPatternCarrier SpawnPattern => null;

		public bool IsDone => false;

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public void LoadData(Action OnComplete = null)
		{
		}

		private void OnOverrideDataLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		private void OnInternalLoad()
		{
		}

		public float PercentComplete()
		{
			return 0f;
		}

		public void Unload()
		{
		}

		public bool Loading()
		{
			return false;
		}
	}
}
