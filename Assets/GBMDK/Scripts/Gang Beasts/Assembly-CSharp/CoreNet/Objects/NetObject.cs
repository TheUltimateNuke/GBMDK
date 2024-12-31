using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public abstract class NetObject : MessageBase
	{
		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public new abstract string ToString();
	}
}
