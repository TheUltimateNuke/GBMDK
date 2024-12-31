using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils.Settings
{
	public class InputOptions : OptionsMenu
	{
		[SerializeField]
		private BoolOptionHandler vibrationOpt;

		[SerializeField]
		private IntOptionHandler mapOpt;

		public Button vibrationButton;

		[SerializeField]
		private RebindScreen _rebindScreen;

		private bool isStartComplete;

		private bool vibrationVal;

		private int controllerMapVal;

		private bool tempVibration;

		private int tempControllerMap;

		[SerializeField]
		private InputMapHandler _mapImage;

		[SerializeField]
		private LocalizedInputMapHandeler _LocalizedMapImage;

		public void ControllerVibrationChanged(bool value)
		{
		}

		public void ControllerMapChanged()
		{
		}

		public void ResetAllInputs(bool save)
		{
		}

		public void ResetPlayerInput()
		{
		}

		public void ResetPlayerInputs(int playerNumber, bool save = true)
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}

		public override void ApplySettings()
		{
		}

		public override void RejectSettings()
		{
		}

		public override void SetupSettings()
		{
		}
	}
}
