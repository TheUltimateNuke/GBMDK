using System.Collections.Generic;
using CoreNet.Utils;
using Femur;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_BigFight : GameMode
	{
		public const string ID = "bigfight";

		private float respawnTimeGap;

		private GameModeUtils.RespawnManager _respawnManager;

		private int _startLives;

		public override void Cleanup()
		{
		}

		public override void Init()
		{
		}

		public override bool IsGameOver()
		{
			return false;
		}

		public override void EndRound()
		{
		}

		public override string GetID()
		{
			return null;
		}

		protected override void InitGang(int gangId)
		{
		}

		public override List<NetGang> GetRoundWinners()
		{
			return null;
		}

		public override List<NetGang> GetGameWinners()
		{
			return null;
		}

		private List<NetGang> CheckWinners()
		{
			return null;
		}

		public override bool IsGameValid()
		{
			return false;
		}

		public override bool IsRoundOver()
		{
			return false;
		}

		public override bool UseGameTimer()
		{
			return false;
		}

		protected override bool GameWinnerFilter(NetGang beast)
		{
			return false;
		}

		public override void OnBeastDeath(NetBeast beast, Actor actor)
		{
		}

		private SpawnParams RespawnParams(NetBeast beast)
		{
			return null;
		}
	}
}
