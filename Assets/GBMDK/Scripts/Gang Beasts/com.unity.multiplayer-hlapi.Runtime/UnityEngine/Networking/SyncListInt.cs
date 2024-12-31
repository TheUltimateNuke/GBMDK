using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncListInt : SyncList<int>
	{
		protected override void SerializeItem(NetworkWriter writer, int item)
		{
		}

		protected override int DeserializeItem(NetworkReader reader)
		{
			return 0;
		}

		[Obsolete("ReadReference is now used instead")]
		public static SyncListInt ReadInstance(NetworkReader reader)
		{
			return null;
		}

		public static void ReadReference(NetworkReader reader, SyncListInt syncList)
		{
		}

		public static void WriteInstance(NetworkWriter writer, SyncListInt items)
		{
		}
	}
}
