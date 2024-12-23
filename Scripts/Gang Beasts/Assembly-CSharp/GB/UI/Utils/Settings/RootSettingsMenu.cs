using UnityEngine;

namespace GB.UI.Utils.Settings
{
	public class RootSettingsMenu : OptionsMenu
	{
		[SerializeField]
		private IntOptionHandler _pingOptRef;

		[SerializeField]
		private MenuHandlerLanguage _langOptRef;

		private int _tempLang;

		private int _tempPing;

		public override void ApplySettings()
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}

		public override void RejectSettings()
		{
		}

		public override void SetupSettings()
		{
		}

		public void ResetSettings()
		{
		}
	}
}
