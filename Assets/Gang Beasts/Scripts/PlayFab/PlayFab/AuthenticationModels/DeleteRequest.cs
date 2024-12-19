using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
	[Serializable]
	public class DeleteRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;
	}
}
