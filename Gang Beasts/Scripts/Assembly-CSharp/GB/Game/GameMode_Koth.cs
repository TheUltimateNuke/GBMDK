using System.Collections.Generic;
using CoreNet.Utils;
using Femur;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_Koth : GameMode
	{
		private static int MAX_TEAMS;

		public const string ID = "koth";

		private List<CoreNetSpawnPosition> _usedFlagSpawns;

		private float respawnTimeGap;

		private GameModeUtils.RespawnManager _respawnManager;

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

		public void SpawnHill(bool start)
		{
		}

		private void RespawnKilledHill(TheHill flagKilled)
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

		public override List<NetGang> GetGameWinners()
		{
			return null;
		}

		protected override bool GameWinnerFilter(NetGang gang)
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
