using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public class NetInt : NetObject
	{
		public int Value;

		public NetInt()
		{
		}

		public NetInt(int value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
