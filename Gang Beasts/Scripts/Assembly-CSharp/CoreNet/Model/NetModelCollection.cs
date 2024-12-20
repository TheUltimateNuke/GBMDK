using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CoreNet.Objects;

namespace CoreNet.Model
{
	public class NetModelCollection<T> where T : NetObject
	{
		public enum Operation
		{
			INSERT = 0,
			UPDATE = 1,
			REMOVE = 2
		}

		public delegate void ItemHandler(T item);

		private List<T> _Items;

		public List<T> Items => null;

		public event ItemHandler OnItemAdded
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

		public event ItemHandler OnItemRemoved
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

		public void Execute(int index, Operation operation, T item, Action onSuccess = null)
		{
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void Insert(int index, T item, Action onSuccess)
		{
		}

		private void Update(int index, T item, Action onSuccess)
		{
		}

		private void Remove(int index, T item, Action onSuccess)
		{
		}
	}
}
