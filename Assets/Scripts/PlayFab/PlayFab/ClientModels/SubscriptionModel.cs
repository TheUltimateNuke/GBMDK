using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class SubscriptionModel : PlayFabBaseModel
	{
		public DateTime Expiration;

		public DateTime InitialSubscriptionTime;

		public bool IsActive;

		public SubscriptionProviderStatus? Status;

		public string SubscriptionId;

		public string SubscriptionItemId;

		public string SubscriptionProvider;
	}
}
