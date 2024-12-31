using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public class NetFloat : NetObject
	{
		public float Value;

		public NetFloat()
		{
		}

		public NetFloat(float value)
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
