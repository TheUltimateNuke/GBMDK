using CoreNet.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetData : NetConnectionAssociation
	{
		private byte[] _data;

		private int size;

		public byte[] Data => null;

		public NetData()
		{
		}

		public NetData(byte[] data)
		{
		}

		public NetData(byte[] data, int size)
		{
		}

		public void Set(byte[] data, int size)
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
