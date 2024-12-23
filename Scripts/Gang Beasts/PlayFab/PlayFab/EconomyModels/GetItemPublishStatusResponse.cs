using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class GetItemPublishStatusResponse : PlayFabResultCommon
	{
		public PublishResult? Result;

		public string StatusMessage;
	}
}
