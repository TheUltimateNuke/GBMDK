using UnityEngine;
using UnityEngine.UI;

namespace GB.UI
{
	public class ButtonPromptHandler : MonoBehaviour
	{
		public ButtonType type;

		[SerializeField]
		private Text actionNameRef;

		public void Setup(string actionName)
		{
		}

		public void Disable()
		{
		}
	}
}
