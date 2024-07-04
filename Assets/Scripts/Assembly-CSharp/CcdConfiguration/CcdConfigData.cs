using System;

namespace CcdConfiguration
{
	[Serializable]
	public class CcdConfigData
	{
		[ReadOnly]
		public string Environment;

		[ReadOnly]
		public string Bucket;

		[ReadOnly]
		public string Badge;

		[ReadOnly]
		public string AccessToken;
	}
}
