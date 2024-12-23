using UnityEngine;

namespace GB.Platform.Utils
{
	public class DisabledIfPlatform : MonoBehaviour
	{
		[SerializeField]
		public bool OnNone;

		[SerializeField]
		public bool OnSteam;

		[SerializeField]
		public bool OnPS4VR;

		[SerializeField]
		public bool OnPS4NoneVR;

		[SerializeField]
		public bool OnOculusVR;

		[SerializeField]
		public bool OnOculusNoneVR;

		[SerializeField]
		public bool OnXboxOne;

		[SerializeField]
		public bool OnSwitch;

		[SerializeField]
		public PlatformOverride OnEditorOverride;

		[SerializeField]
		public PlatformOverride OnOverride;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void RunChecks()
		{
		}
	}
}
