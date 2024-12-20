using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coatsink
{
	[Serializable]
	public class SerialisableDictionary<TK, TV> : ISerializationCallbackReceiver
	{
		[SerializeField]
		private TK[] keys;

		[SerializeField]
		private TV[] vals;

		public bool autoReconstruct;

		private Dictionary<TK, TV> dict_;

		public Dictionary<TK, TV> dict => null;

		private bool unconstructed => false;

		public void Reconstruct()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		private void InternalReconstruct()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
