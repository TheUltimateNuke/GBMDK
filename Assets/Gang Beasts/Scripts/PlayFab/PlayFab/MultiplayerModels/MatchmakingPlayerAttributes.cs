using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class MatchmakingPlayerAttributes : PlayFabBaseModel
	{
		public object DataObject;

		public string EscapedDataObject;
	}
}
