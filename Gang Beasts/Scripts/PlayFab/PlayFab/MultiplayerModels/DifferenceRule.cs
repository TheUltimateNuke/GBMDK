using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class DifferenceRule : PlayFabBaseModel
	{
		public QueueRuleAttribute Attribute;

		public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior;

		public CustomDifferenceRuleExpansion CustomExpansion;

		public double? DefaultAttributeValue;

		public double Difference;

		public LinearDifferenceRuleExpansion LinearExpansion;

		public AttributeMergeFunction MergeFunction;

		public string Name;

		public uint? SecondsUntilOptional;

		public double Weight;
	}
}
