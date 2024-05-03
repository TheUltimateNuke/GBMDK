using System;
using TMPro;
using UnityEngine.UI;

namespace GB.UI
{
	[Serializable]
	public class RebindTuple
	{
		public TextMeshProUGUI ActionName;

		public Button ActionButton;

		public TextMeshProUGUI BindingNameController;

		public TextMeshProUGUI BindingNameKeyboard;

		public TextMeshProUGUI BindingNameMouse;

		public void Set(string action, string controllerBinding, string keyboardBinding, string mouseBinding, RebindScreen.InputBindAction response)
		{
		}
	}
}
