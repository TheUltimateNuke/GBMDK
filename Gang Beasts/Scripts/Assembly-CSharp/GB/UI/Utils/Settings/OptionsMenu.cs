using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Utils.Settings
{
	public abstract class OptionsMenu : MonoBehaviour
	{
		protected bool _preventReset;

		[SerializeField]
		private UnityEvent OnAttemptedQuitNewSettings;

		[SerializeField]
		private UnityEvent OnAttemptQuitOldSettings;

		public void OnEnable()
		{
		}

		public void QuitCheck()
		{
		}

		public void OnDisable()
		{
		}

		public void PreventReset()
		{
		}

		public abstract void SetupSettings();

		public abstract void ApplySettings();

		public abstract void RejectSettings();

		public abstract bool HaveSettingsChanged();
	}
}
