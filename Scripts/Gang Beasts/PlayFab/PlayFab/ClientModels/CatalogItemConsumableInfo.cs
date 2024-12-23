using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class CatalogItemConsumableInfo : PlayFabBaseModel
	{
		public uint? UsageCount;

		public uint? UsagePeriod;

		public string UsagePeriodGroup;
	}
}
