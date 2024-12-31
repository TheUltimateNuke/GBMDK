using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace GB.UI.Utils.Settings
{
	[Serializable]
	public class LocalizedInputMapEntry
	{
		[SerializeField]
		public string InputName;

		[SerializeField]
		public List<LocalizedString> _localeStrings;

		public LocalizedInputMapEntry()
		{
		}

		public LocalizedInputMapEntry(string name)
		{
		}
	}
}
