using System;
using System.Collections.Generic;
using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Model
{
	public class NetItemBucket<T> : NetBucket where T : NetObject, new()
	{
		private Dictionary<string, NetModelItem<T>> _Items;

		public NetItemBucket(short code)
		{
		}

		public T Get(string key)
		{
			return null;
		}

		public void Set(string key, T item, Action onSuccess = null)
		{
		}

		public void Subscribe(string key, NetModelItem<T>.ItemHandler handler)
		{
		}

		public void Unsubscribe(string key, NetModelItem<T>.ItemHandler handler)
		{
		}

		public override void Clear()
		{
		}

		public override void PropagateAllToClient(NetworkConnection conn)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
