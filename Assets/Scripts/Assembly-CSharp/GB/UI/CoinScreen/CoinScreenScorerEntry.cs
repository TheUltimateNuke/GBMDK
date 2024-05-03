using UnityEngine;

namespace GB.UI.CoinScreen
{
	public class CoinScreenScorerEntry : MonoBehaviour
	{
		[SerializeField]
		private RectTransform BeastFieldParentRef;

		[SerializeField]
		private RectTransform ScoreFieldParentRef;

		private const string BEAST_BALLOON_RESOURCE_PATH = "CoinScreen/UIDummies/UIBeastFaceDummy";

		private const string STAR_FILLED_BALLOON_RESOURCE_PATH = "CoinScreen/UIDummies/UIFilledStarDummy";

		private const string STAR_EMPTY_BALLOON_RESOURCE_PATH = "CoinScreen/UIDummies/UIEmptyStarDummy";

		private int previousScore;

		private CoinScreenBalloon _cachedBeastFace;

		private GameObject[] spawnedEmptyBalloons;

		private CoinScreenBalloon[] spawnedFilledBalloons;

		public Color _cachedBeastColor;

		private bool _isDestroying;

		public void SetupBeastSection(Color beastColor, int numEntries)
		{
		}

		public void SetupScoreSection(int startScore, int maxScore, int numEntries, AudioClip inflate, AudioClip pop)
		{
		}

		public void ResizeEntry(int numEntries)
		{
		}

		public void UpdateScoreSection(int newScore)
		{
		}

		public void Destroy()
		{
		}
	}
}
