using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public sealed class SyncListFloat : SyncList<float>
	{
		protected override void SerializeItem(NetworkWriter writer, float item)
		{
		}

		protected override float DeserializeItem(NetworkReader reader)
		{
			return 0f;
		}

		[Obsolete("ReadReference is now used instead")]
		public static SyncListFloat ReadInstance(NetworkReader reader)
		{
			return null;
		}

		public static void ReadReference(NetworkReader reader, SyncListFloat syncList)
		{
		}

		public static void WriteInstance(NetworkWriter writer, SyncListFloat items)
		{
		}
	}
}
