using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class MembershipModel : PlayFabBaseModel
	{
		public bool IsActive;

		public DateTime MembershipExpiration;

		public string MembershipId;

		public DateTime? OverrideExpiration;

		public List<SubscriptionModel> Subscriptions;
	}
}
