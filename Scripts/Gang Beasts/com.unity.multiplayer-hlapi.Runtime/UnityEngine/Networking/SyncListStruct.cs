using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncListStruct<T> : SyncList<T> where T : struct
	{
		public new ushort Count => 0;

		public new void AddInternal(T item)
		{
		}

		protected override void SerializeItem(NetworkWriter writer, T item)
		{
		}

		protected override T DeserializeItem(NetworkReader reader)
		{
			return default(T);
		}

		public T GetItem(int i)
		{
			return default(T);
		}
	}
}
