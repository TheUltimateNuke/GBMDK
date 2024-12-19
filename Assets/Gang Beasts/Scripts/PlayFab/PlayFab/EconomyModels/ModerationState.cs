using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class ModerationState : PlayFabBaseModel
	{
		public DateTime? LastModifiedDate;

		public string Reason;

		public ModerationStatus? Status;
	}
}
