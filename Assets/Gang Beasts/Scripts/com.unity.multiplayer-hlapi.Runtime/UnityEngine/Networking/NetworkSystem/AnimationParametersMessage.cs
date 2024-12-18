namespace UnityEngine.Networking.NetworkSystem
{
	internal class AnimationParametersMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public byte[] parameters;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
