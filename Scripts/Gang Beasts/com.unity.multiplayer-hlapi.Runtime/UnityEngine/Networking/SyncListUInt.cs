using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncListUInt : SyncList<uint>
	{
		protected override void SerializeItem(NetworkWriter writer, uint item)
		{
		}

		protected override uint DeserializeItem(NetworkReader reader)
		{
			return 0u;
		}

		[Obsolete("ReadReference is now used instead")]
		public static SyncListUInt ReadInstance(NetworkReader reader)
		{
			return null;
		}

		public static void ReadReference(NetworkReader reader, SyncListUInt syncList)
		{
		}

		public static void WriteInstance(NetworkWriter writer, SyncListUInt items)
		{
		}
	}
}
