using System;
using UnityEngine;

namespace GB.Core.UI
{
	public class UIManager : MonoBehaviour
	{
		private bool _spectatingUI;

		public static Action<bool> OnSpectatingUIChanged;

		private bool _voipUI;

		public static Action<bool> OnVoipUIChanged;

		private int _pingUISetting;

		public static Action<int> OnPingUISettingChanged;

		public bool SpectatingUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool VoipUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int PingUISetting
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ResetSettings()
		{
		}

		public void LoadUISettings()
		{
		}

		public void SaveUISettings()
		{
		}
	}
}
