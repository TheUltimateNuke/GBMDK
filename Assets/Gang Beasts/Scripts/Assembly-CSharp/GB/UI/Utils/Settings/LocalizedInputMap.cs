using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.UI.Utils.Settings
{
	[Serializable]
	public class LocalizedInputMap
	{
		[SerializeField]
		public string MapName;

		[SerializeField]
		public int index;

		[SerializeField]
		public Sprite ImageOverride;

		[SerializeField]
		public List<LocalizedInputMapEntry> _inputs;
	}
}
