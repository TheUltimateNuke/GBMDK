using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public class NetString : NetObject
	{
		public string Value;

		public NetString()
		{
		}

		public NetString(string value)
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
