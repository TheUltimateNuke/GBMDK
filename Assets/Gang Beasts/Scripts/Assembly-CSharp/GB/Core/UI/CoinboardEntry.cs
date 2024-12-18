using System.Collections.Generic;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class CoinboardEntry : BoardEntry
	{
		[SerializeField]
		private RectTransform HeadSection;

		[SerializeField]
		private RectTransform ScoreSection;

		[SerializeField]
		private GameObject BeastHeadRef;

		[SerializeField]
		private GameObject ScoreRef;

		private List<RawImage> _headObjects;

		private List<RawImage> _ScoreObjects;

		private Color filledScoreColour;

		private int previousScore;

		public override void Initialise(int connId, int contId)
		{
		}

		public override void UpdateUI(NetBeast beast, NetPlatform platform, bool forceImageReload = false)
		{
		}

		private void SpawnNewEntry(NetBeast beast, NetPlatform platform)
		{
		}

		private void UpdateExistingEntry(NetBeast beast, NetPlatform platform)
		{
		}

		private void FlushPreviousSprites()
		{
		}

		private void AddBeastHead(NetBeast beast, bool spectating)
		{
		}

		private void AddScoreCounter(bool spectating)
		{
		}
	}
}
