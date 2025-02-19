using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class SyncList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		public delegate void SyncListChanged(Operation op, int itemIndex);

		public enum Operation
		{
			OP_ADD = 0,
			OP_CLEAR = 1,
			OP_INSERT = 2,
			OP_REMOVE = 3,
			OP_REMOVEAT = 4,
			OP_SET = 5,
			OP_DIRTY = 6
		}

		private List<T> m_Objects;

		private NetworkBehaviour m_Behaviour;

		private int m_CmdHash;

		private SyncListChanged m_Callback;

		public int Count => 0;

		public bool IsReadOnly => false;

		public SyncListChanged Callback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T this[int i]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		protected abstract void SerializeItem(NetworkWriter writer, T item);

		protected abstract T DeserializeItem(NetworkReader reader);

		public void InitializeBehaviour(NetworkBehaviour beh, int cmdHash)
		{
		}

		private void SendMsg(Operation op, int itemIndex, T item)
		{
		}

		private void SendMsg(Operation op, int itemIndex)
		{
		}

		public void HandleMsg(NetworkReader reader)
		{
		}

		internal void AddInternal(T item)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int index)
		{
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public void Dirty(int index)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
