using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
	[Serializable]
	public class GetFileMetadata : PlayFabBaseModel
	{
		public string Checksum;

		public string DownloadUrl;

		public string FileName;

		public DateTime LastModified;

		public int Size;
	}
}
