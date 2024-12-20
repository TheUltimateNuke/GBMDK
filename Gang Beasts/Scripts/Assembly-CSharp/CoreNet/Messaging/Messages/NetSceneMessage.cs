using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetSceneMessage : MessageBase
	{
		public string SceneName;

		public NetSceneMessage()
		{
		}

		public NetSceneMessage(string sceneName)
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
