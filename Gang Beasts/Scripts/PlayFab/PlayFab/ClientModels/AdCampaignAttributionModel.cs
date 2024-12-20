using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class AdCampaignAttributionModel : PlayFabBaseModel
	{
		public DateTime AttributedAt;

		public string CampaignId;

		public string Platform;
	}
}
