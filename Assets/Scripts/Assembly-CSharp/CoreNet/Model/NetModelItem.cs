using System;
using System.Runtime.CompilerServices;
using CoreNet.Objects;

namespace CoreNet.Model
{
	public class NetModelItem<T> where T : NetObject
	{
		public delegate void ItemHandler(T item);

		private T _Item;

		public T Item => null;

		public event ItemHandler OnItemUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Set(T item, Action onSuccess = null)
		{
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
