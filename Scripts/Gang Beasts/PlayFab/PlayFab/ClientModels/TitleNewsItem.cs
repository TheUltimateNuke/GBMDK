using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class TitleNewsItem : PlayFabBaseModel
	{
		public string Body;

		public string NewsId;

		public DateTime Timestamp;

		public string Title;
	}
}
