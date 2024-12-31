using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class TransactionOperation : PlayFabBaseModel
	{
		public int? Amount;

		public double? DurationInSeconds;

		public string ItemId;

		public string ItemType;

		public string StackId;

		public string Type;
	}
}
