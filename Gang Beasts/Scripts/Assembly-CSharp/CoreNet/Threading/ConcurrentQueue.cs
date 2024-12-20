using System.Collections.Generic;

namespace CoreNet.Threading
{
	public class ConcurrentQueue<T>
	{
		private List<T> _List;

		private object _SyncLock;

		public void Add(T value)
		{
		}

		public void Clear()
		{
		}

		public T GetNext()
		{
			return default(T);
		}

		public int GetCount()
		{
			return 0;
		}
	}
}
