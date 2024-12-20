using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class MainUserInteractOnly : MonoBehaviour
	{
		[SerializeField]
		private bool _mainWanted;

		[SerializeField]
		private Selectable _selectable;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void GBUIInputHandler_OnLastInputChanged(int obj)
		{
		}
	}
}
