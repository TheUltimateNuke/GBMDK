using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class LinearTeamDifferenceRuleExpansion : PlayFabBaseModel
	{
		public double Delta;

		public double? Limit;

		public uint SecondsBetweenExpansions;
	}
}
