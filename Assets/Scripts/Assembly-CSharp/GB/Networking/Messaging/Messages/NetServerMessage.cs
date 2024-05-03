using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Messaging.Messages
{
	public class NetServerMessage : MessageBase
	{
		public float lifeTime;

		public float fadeTime;

		public string message;

		public Color colour;

		public Vector3 offSet;

		public bool world;

		public NetServerMessage()
		{
		}

		public NetServerMessage(string text, float messageLifeTime = 1f)
		{
		}

		public NetServerMessage(string text, Vector3 worldSpace, float messageLifeTime = 1f)
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
