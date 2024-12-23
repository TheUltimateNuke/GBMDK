using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class UploadCertificateRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public Certificate GameCertificate;
	}
}
