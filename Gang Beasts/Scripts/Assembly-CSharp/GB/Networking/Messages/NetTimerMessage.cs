using UnityEngine.Networking;

namespace GB.Networking.Messages
{
	public class NetTimerMessage : MessageBase
	{
		public int time;

		public NetTimerMessage()
		{
		}

		public NetTimerMessage(int time)
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
