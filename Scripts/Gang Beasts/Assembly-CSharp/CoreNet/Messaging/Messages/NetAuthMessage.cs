using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetAuthMessage : MessageBase
	{
		public bool ClientAuthPassed;

		public int Players;

		public string PlatformID;

		public string Password;

		public double Version;

		public bool Debug;

		public NetAuthMessage()
		{
		}

		public NetAuthMessage(bool clientAuthPassed, int players, string platformID, string password, double version, bool debug)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
