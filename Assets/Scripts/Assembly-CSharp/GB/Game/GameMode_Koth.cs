using System.Collections.Generic;
using Femur;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_Koth : GameMode
	{
		private static int WIN_COUNT;

		public const string ID = "koth";

		public Dictionary<int, int> gangHillCount;

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

		private void Tick(TheHill hill, Actor hillOwner)
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
