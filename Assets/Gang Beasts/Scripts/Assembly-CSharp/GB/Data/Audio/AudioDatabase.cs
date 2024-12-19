using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Data.Audio
{
	public class AudioDatabase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct Element
		{
			[SerializeField]
			public string key;

			[SerializeField]
			public AudioDatabaseItem audio;

			public Element(string keyValue, AudioDatabaseItem audioValue)
			{
				key = null;
				audio = null;
			}
		}

		public Dictionary<string, AudioDatabaseItem> Default;

		[SerializeField]
		private List<Element> _serializer;

		[SerializeField]
		private int _markers;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
