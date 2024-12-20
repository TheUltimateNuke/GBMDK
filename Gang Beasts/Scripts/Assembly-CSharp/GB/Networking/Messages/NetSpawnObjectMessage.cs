using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Messages
{
	public class NetSpawnObjectMessage : MessageBase
	{
		public int objectID;

		public Vector3 worldPos;

		public bool randomiseRotation;

		public NetSpawnObjectMessage()
		{
		}

		public NetSpawnObjectMessage(int objectId, Vector3 pos, bool randomRot)
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
