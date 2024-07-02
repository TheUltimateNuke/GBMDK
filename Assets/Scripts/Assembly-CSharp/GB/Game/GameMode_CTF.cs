using System.Collections.Generic;
using CoreNet.Utils;
using Femur;
using GB.Gamemodes.CTF;
using GB.Networking.Objects;

namespace GB.Game
{
	public class GameMode_CTF : GameMode
	{
		public const string ID = "ctf";

		private List<CoreNetSpawnPosition> usedSpawns;

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

		public void SpawnFlags(bool start, int count)
		{
		}

		public void SpawnFlag(int gangID, bool start)
		{
		}

		public void SpawnFlag(int gangID, SpawnParams flagSpawnParams)
		{
		}

		private void RespawnKilledFlag(Flag flagKilled)
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

		private void FlagCapture(FlagCapturePoint flagCP, Flag flag)
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
