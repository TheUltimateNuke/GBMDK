using System.Collections.Generic;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_CTF : GameMode
	{
		public const string ID = "ctf";

		private static int FLAG_COUNT;

		private static int FLAG_WIN_COUNT;

		public Dictionary<int, int> playerFlagCount;

		public override string GetID()
		{
			return null;
		}

		protected override void InitBeast(NetBeast pBeast)
		{
		}

		public override void Cleanup()
		{
		}

		public override void InitRound()
		{
		}

		public override void StartRound()
		{
		}

		public override bool IsGameValid()
		{
			return false;
		}

		public override void EndRound()
		{
		}

		private void FlagCapture(FlagCapturePoint flagCP)
		{
		}

		public override bool IsRoundOver()
		{
			return false;
		}

		public override List<NetGang> GetRoundWinners()
		{
			return null;
		}

		protected override bool GameWinnerFilter(NetGang gang)
		{
			return false;
		}
	}
}
