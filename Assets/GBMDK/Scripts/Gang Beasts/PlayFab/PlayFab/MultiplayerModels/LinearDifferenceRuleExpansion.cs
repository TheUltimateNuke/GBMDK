using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class LinearDifferenceRuleExpansion : PlayFabBaseModel
	{
		public double Delta;

		public double? Limit;

		public uint SecondsBetweenExpansions;
	}
}
