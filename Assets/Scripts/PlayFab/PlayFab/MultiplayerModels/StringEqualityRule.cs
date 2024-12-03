using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class StringEqualityRule : PlayFabBaseModel
	{
		public QueueRuleAttribute Attribute;

		public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior;

		public string DefaultAttributeValue;

		public StringEqualityRuleExpansion Expansion;

		public string Name;

		public uint? SecondsUntilOptional;

		public double Weight;
	}
}
