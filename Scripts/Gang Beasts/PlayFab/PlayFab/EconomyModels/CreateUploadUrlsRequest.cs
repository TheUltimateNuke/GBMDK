using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CreateUploadUrlsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<UploadInfo> Files;
	}
}
