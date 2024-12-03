using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumeItemRequest : PlayFabRequestCommon
	{
		public string CharacterId;

		public int ConsumeCount;

		public Dictionary<string, string> CustomTags;

		public string ItemInstanceId;
	}
}
