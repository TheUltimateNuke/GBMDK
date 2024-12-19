namespace UnityEngine.Networking.NetworkSystem
{
	internal class AnimationMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public int stateHash;

		public float normalizedTime;

		public byte[] parameters;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
