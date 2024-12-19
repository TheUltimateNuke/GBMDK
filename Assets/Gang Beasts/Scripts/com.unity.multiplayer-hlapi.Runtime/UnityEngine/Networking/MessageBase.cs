using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public abstract class MessageBase
	{
		public virtual void Deserialize(NetworkReader reader)
		{
		}

		public virtual void Serialize(NetworkWriter writer)
		{
		}
	}
}
