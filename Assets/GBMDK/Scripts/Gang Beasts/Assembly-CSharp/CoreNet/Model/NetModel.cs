using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CoreNet.Messaging;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Model
{
	public class NetModel : MonoBehaviour
	{
		public class QueueCheck : EventArgs
		{
			public bool Passed { get; set; }

			public bool IsUsed { get; set; }

			public void Reset()
			{
			}
		}

		private bool _Locked;

		private Dictionary<Type, NetBucket> _ItemBuckets;

		private Dictionary<Type, NetBucket> _CollectionBuckets;

		private Queue<Action> _PropagationQueue;

		private QueueCheck _queueEventArgs;

		public event Action<QueueCheck> OnMessageLockQueueCheck
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

		public void Awake()
		{
		}

		public List<T> GetCollection<T>(string key) where T : NetObject, new()
		{
			return null;
		}

		public int GetCollectionSize(string key)
		{
			return 0;
		}

		public T GetItem<T>(string key) where T : NetObject, new()
		{
			return null;
		}

		public void SetItem<T>(string key, T item) where T : NetObject, new()
		{
		}

		public void Add<T>(string key, T item) where T : NetObject, new()
		{
		}

		public void Clear<T>(string key) where T : NetObject, new()
		{
		}

		public void Insert<T>(string key, int index, T item) where T : NetObject, new()
		{
		}

		public bool UpdateCollectionItem<T>(string key, T item) where T : NetObject, new()
		{
			return false;
		}

		public void Remove<T>(string key, T item) where T : NetObject, new()
		{
		}

		public void Remove<T>(string key, int index, T item) where T : NetObject, new()
		{
		}

		public void Execute<T>(string key, int index, NetModelCollection<T>.Operation operation, T item) where T : NetObject, new()
		{
		}

		public void Execute<T>(string key, int index, NetModelCollection<T>.Operation operation, T item, NetCollectionBucket<T> bucket) where T : NetObject, new()
		{
		}

		public void Subscribe<T>(string key, NetModelItem<T>.ItemHandler handler) where T : NetObject, new()
		{
		}

		public void Subscribe<T>(string key, NetModelCollection<T>.ItemHandler addHandler, NetModelCollection<T>.ItemHandler updateHandler, NetModelCollection<T>.ItemHandler removeHandler) where T : NetObject, new()
		{
		}

		public void Unsubscribe<T>(string key, NetModelItem<T>.ItemHandler handler) where T : NetObject, new()
		{
		}

		public void Unsubscribe<T>(string key, NetModelCollection<T>.ItemHandler addHandler, NetModelCollection<T>.ItemHandler updateHandler, NetModelCollection<T>.ItemHandler removeHandler) where T : NetObject, new()
		{
		}

		public void RegisterCollection<T>(short code = -1) where T : NetObject, new()
		{
		}

		public void RegisterItem<T>(short code = -1) where T : NetObject, new()
		{
		}

		public void Print()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Lock()
		{
		}

		public void Unlock()
		{
		}

		public void ClearSyncables()
		{
		}

		public void PropagateSyncablesToClient(NetworkConnection conn)
		{
		}

		private void DequeuePropagations()
		{
		}

		private void NetCollectionMessageHandler<T>(NetCollectionMessage<T> message, NetworkConnection conn) where T : NetObject, new()
		{
		}

		private void NetItemMessageHandler<T>(NetItemMessage<T> message, NetworkConnection conn) where T : NetObject, new()
		{
		}

		private bool Propagate<T>(string key, NetItemBucket<T> bucket) where T : NetObject, new()
		{
			return false;
		}

		private bool Propagate<T>(string key, int index, NetModelCollection<T>.Operation operation, T item, NetCollectionBucket<T> bucket) where T : NetObject, new()
		{
			return false;
		}

		private void Register<T1, T2>(NetBucket bucket, Dictionary<Type, NetBucket> bucketDict, NetMessenger.MessageCallback<T2> handler) where T1 : NetObject where T2 : MessageBase, new()
		{
		}
	}
}
