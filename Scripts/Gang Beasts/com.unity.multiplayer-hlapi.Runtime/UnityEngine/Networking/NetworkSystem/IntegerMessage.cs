using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class IntegerMessage : MessageBase
	{
		public int value;

		public IntegerMessage()
		{
		}

		public IntegerMessage(int v)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
