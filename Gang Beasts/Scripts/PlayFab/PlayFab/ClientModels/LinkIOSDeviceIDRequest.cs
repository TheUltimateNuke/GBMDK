using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkIOSDeviceIDRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string DeviceId;

		public string DeviceModel;

		public bool? ForceLink;

		public string OS;
	}
}
