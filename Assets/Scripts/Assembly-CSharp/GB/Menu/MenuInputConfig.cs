using System.Collections.Generic;
using UnityEngine;

namespace GB.Menu
{
	public class MenuInputConfig : ScriptableObject
	{
		[SerializeField]
		public List<InputActionMap> ps4ActionMap;

		[SerializeField]
		public List<InputActionMap> xboxActionMap;

		[SerializeField]
		public List<InputActionMap> switchActionMap;

		[SerializeField]
		public List<InputActionMap> switchHorizontalActionMap;

		[SerializeField]
		public List<InputActionMap> keyboardMouseActionMap;
	}
}
