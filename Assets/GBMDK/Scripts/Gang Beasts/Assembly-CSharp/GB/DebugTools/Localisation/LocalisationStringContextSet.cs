using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.DebugTools.Localisation
{
	[Serializable]
	[CreateAssetMenu(menuName = "Test")]
	public class LocalisationStringContextSet : ScriptableObject
	{
		public string _testSceneName;

		public GameObject localisationTesting;

		public bool _hideUnused;

		public List<LocalisationStringContext> contexts;

		public List<LocalisationStringContext> GetAllUsedContexts()
		{
			return null;
		}

		public bool FindContext(string key, out int index)
		{
			index = default(int);
			return false;
		}
	}
}
