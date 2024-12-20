using System;
using System.Collections.Generic;
using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Model
{
	public class NetCollectionBucket<T> : NetBucket, INetCollection where T : NetObject, new()
	{
		private Dictionary<string, NetModelCollection<T>> _Collections;

		public NetCollectionBucket(short code)
		{
		}

		public void Execute(string key, int index, NetModelCollection<T>.Operation operation, T item, Action onSuccess = null)
		{
		}

		public List<T> Get(string key)
		{
			return null;
		}

		public int GetCount(string key)
		{
			return 0;
		}

		public int IndexOf(string key, T item)
		{
			return 0;
		}

		public void Subscribe(string key, NetModelCollection<T>.ItemHandler addedHandler, NetModelCollection<T>.ItemHandler updateHandler, NetModelCollection<T>.ItemHandler removedHandler)
		{
		}

		public void Unsubscribe(string key, NetModelCollection<T>.ItemHandler addedHandler, NetModelCollection<T>.ItemHandler updateHandler, NetModelCollection<T>.ItemHandler removedHandler)
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
