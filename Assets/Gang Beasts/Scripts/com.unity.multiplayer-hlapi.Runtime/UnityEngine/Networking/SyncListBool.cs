using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncListBool : SyncList<bool>
	{
		protected override void SerializeItem(NetworkWriter writer, bool item)
		{
		}

		protected override bool DeserializeItem(NetworkReader reader)
		{
			return false;
		}

		[Obsolete("ReadReference is now used instead")]
		public static SyncListBool ReadInstance(NetworkReader reader)
		{
			return null;
		}

		public static void ReadReference(NetworkReader reader, SyncListBool syncList)
		{
		}

		public static void WriteInstance(NetworkWriter writer, SyncListBool items)
		{
		}
	}
}
