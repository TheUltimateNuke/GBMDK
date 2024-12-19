using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils.Settings
{
	public class InputMapHandler : MonoBehaviour
	{
		[Serializable]
		public class InputMap : ISerializationCallbackReceiver
		{
			public string _name;

			public Dictionary<int, string> _inputs;

			public Sprite _imageOverride;

			[SerializeField]
			private List<int> _inputKeys;

			[SerializeField]
			private List<string> _inputValues;

			public void OnAfterDeserialize()
			{
			}

			public void OnBeforeSerialize()
			{
			}
		}

		[SerializeField]
		private Transform _mapTextFieldParent;

		[SerializeField]
		private Image _overrideImage;

		[SerializeField]
		private List<TextReplacer> _mapTextFieldComponents;

		[SerializeField]
		private static List<string> _mapTextFieldNames;

		[SerializeField]
		private List<InputMap> _maps;

		[SerializeField]
		private int _defaultMapIndex;

		private void Awake()
		{
		}

		public void LoadMap(int index)
		{
		}

		[ContextMenu("Generate Map Field")]
		private void GenerateMapField()
		{
		}

		public string[] GetMapFieldNames()
		{
			return null;
		}

		public string GetCurrentFieldText(int index, bool checkLink = false)
		{
			return null;
		}
	}
}
