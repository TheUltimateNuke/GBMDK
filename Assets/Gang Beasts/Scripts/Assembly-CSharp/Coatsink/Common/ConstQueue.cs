namespace Coatsink.Common
{
	public class ConstQueue<T> where T : new()
	{
		public T[] _data;

		private int _dataIndexCurrent;

		private int _dataIndexTarget;

		public int FrontIndex => 0;

		public int MaxSize => 0;

		public bool Any => false;

		public T this[int index] => default(T);

		public int Length
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ConstQueue(int size)
		{
		}

		public void Enqueue(T obj)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}

		public void Clear()
		{
		}

		public T Peek()
		{
			return default(T);
		}
	}
}
