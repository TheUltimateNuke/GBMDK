namespace UnityEngine.Networking.NetworkSystem
{
	internal class AnimationTriggerMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public int hash;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
