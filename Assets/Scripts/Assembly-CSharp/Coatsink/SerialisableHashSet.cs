using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coatsink
{
	[Serializable]
	public class SerialisableHashSet<T> : HashSet<T>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private T[] entries;

		public SerialisableHashSet()
		{
		}

		public SerialisableHashSet(IEnumerable<T> pop)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
