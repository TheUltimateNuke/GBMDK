using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Gamemodes
{
	[Serializable]
	public class GameModeMapTracker
	{
		[SerializeField]
		public List<ModeMapStatus> AvailableMaps;

		public List<ModeMapStatus> GetMapsFor(GameModeEnum mode, bool forLocal = true)
		{
			return null;
		}
	}
}
