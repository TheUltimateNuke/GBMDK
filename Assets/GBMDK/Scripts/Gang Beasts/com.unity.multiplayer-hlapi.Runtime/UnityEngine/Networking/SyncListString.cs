using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public sealed class SyncListString : SyncList<string>
	{
		protected override void SerializeItem(NetworkWriter writer, string item)
		{
		}

		protected override string DeserializeItem(NetworkReader reader)
		{
			return null;
		}

		[Obsolete("ReadReference is now used instead")]
		public static SyncListString ReadInstance(NetworkReader reader)
		{
			return null;
		}

		public static void ReadReference(NetworkReader reader, SyncListString syncList)
		{
		}

		public static void WriteInstance(NetworkWriter writer, SyncListString items)
		{
		}
	}
}
