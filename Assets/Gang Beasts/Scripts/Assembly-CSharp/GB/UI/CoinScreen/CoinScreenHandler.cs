using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.UI.CoinScreen
{
	public class CoinScreenHandler : MonoBehaviour
	{
		[SerializeField]
		private RectTransform EntryFieldParentRef;

		[SerializeField]
		private AudioClip InflateAudioClip;

		[SerializeField]
		private AudioClip PopAudioClip;

		public static Action OnCoinScreenShow;

		public static Action OnCoinScreenHide;

		private float prevSFXVolume;

		private float prevVocalVolume;

		private static GameObject _coinScreenEntry;

		private const string COIN_SCREEN_SCORE_ENTRY_PATH = "CoinScreen/CoinScreenEntry";

		private int _cachedMaxScore;

		private bool _coinScreenActive;

		private List<CoinScreenScorerEntry> _spawnedEntries;

		private static GameObject CoinScreenEntry => null;

		public bool CoinScreenActive => false;

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

		private void VolumeSettingsChanged()
		{
		}

		public void Setup(int maxScore, Color[] scorers, int[] startScores)
		{
		}

		public void AppendSetup(int maxScore, Color[] allScorers, int startScore = 0)
		{
		}

		public void UpdateHandler(ScoreSimplifier[] scores)
		{
		}

		private void ClearSpawnedEntries()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}
}
