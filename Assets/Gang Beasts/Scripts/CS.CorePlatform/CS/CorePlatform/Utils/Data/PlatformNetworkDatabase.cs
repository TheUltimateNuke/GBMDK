using System;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
	public class PlatformNetworkDatabase : ScriptableObject
	{
		[Serializable]
		public class XboxInfo
		{
			public string SessionTemplateName;

			public string ServerSessionTemplateName;

			public string TCPTemplate;

			public string UDPTemplate;

			public int TCPPort;

			public int UDPPort;

			public string ChatTemplate;

			public int ChatPort;
		}

		[SerializeField]
		public XboxInfo XboxNetwork;
	}
}
