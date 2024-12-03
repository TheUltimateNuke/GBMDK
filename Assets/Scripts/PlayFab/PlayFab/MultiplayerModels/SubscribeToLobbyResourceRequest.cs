using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class SubscribeToLobbyResourceRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey EntityKey;

		public string PubSubConnectionHandle;

		public string ResourceId;

		public uint SubscriptionVersion;

		public SubscriptionType Type;
	}
}
