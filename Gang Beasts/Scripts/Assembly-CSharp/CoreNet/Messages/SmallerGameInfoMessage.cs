using UnityEngine.Networking;

namespace CoreNet.Messages
{
	public class SmallerGameInfoMessage : MessageBase
	{
		public string IPAddress;

		public int Port;

		public string GameName;

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
