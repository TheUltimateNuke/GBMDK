using System;
using UnityEngine;

namespace GB.Platform.Utils
{
	[Serializable]
	public struct PlatformBools
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

		private int value;

		public bool Value => false;

		public void Check()
		{
		}
	}
}
