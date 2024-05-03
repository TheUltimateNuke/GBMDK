using UnityEngine;
using UnityEngine.InputSystem;

namespace GB.DebugTools.Localisation
{
	public class LocalisationTestingOpener : MonoBehaviour
	{
		public LocalisationStringContextSet _set;

		public InputAction _openAction;

		private void Start()
		{
		}

		private void _openAction_performed(InputAction.CallbackContext obj)
		{
		}
	}
}
