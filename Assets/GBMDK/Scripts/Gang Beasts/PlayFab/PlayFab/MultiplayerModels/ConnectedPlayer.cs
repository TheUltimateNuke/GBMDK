using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ConnectedPlayer : PlayFabBaseModel
	{
		public string PlayerId;
	}
}
