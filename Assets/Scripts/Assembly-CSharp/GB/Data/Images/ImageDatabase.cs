using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Data.Images
{
	public class ImageDatabase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct Element
		{
			[SerializeField]
			public string key;

			[SerializeField]
			public Texture image;

			public Element(string keyValue, Texture imageValue):this()
			{
			}
		}

		public Dictionary<string, Texture> Default;

		public Dictionary<string, Texture>[] Platform;

		[SerializeField]
		private List<Element> _serializer;

		[SerializeField]
		private int[] _markers;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
