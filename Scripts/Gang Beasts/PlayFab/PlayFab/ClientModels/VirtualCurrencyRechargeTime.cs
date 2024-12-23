using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class VirtualCurrencyRechargeTime : PlayFabBaseModel
	{
		public int RechargeMax;

		public DateTime RechargeTime;

		public int SecondsToRecharge;
	}
}
