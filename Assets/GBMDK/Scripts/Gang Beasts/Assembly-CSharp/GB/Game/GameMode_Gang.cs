using System.Collections.Generic;
using Femur;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_Gang : GameMode
	{
		public const string ID = "gang";

		public override string GetID()
		{
			return null;
		}

		public override void Cleanup()
		{
		}

		public override bool IsGameValid()
		{
			return false;
		}

		public override void SetupGangIDsForOnlineSession(int totalPlayers, bool privateGame)
		{
		}

		public override void EndRound()
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

		public override void SendRoundOverMessage(bool mapComplete)
		{
		}

		public override void OnBeastDeath(NetBeast beast, Actor actor)
		{
		}

		public override void HandleScore()
		{
		}

		protected override bool GameWinnerFilter(NetGang gang)
		{
			return false;
		}
	}
}
