using CoreNet.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetByteArray : NetObject
	{
		public byte[] Data;

		public NetByteArray()
		{
		}

		public NetByteArray(byte[] data)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
