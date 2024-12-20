using System;
using System.Collections.Generic;

namespace GB.Utils
{
	public class Pool<T>
	{
		private readonly Stack<T> objects;

		private readonly Func<T> objectGenerator;

		public int Count => 0;

		public Pool(Func<T> objectGenerator)
		{
		}

		public T Take()
		{
			return default(T);
		}

		public void Return(T item)
		{
		}
	}
}
