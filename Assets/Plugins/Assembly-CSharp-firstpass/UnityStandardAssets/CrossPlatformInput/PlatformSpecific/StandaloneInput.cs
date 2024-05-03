using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	public class StandaloneInput : VirtualInput
	{
		public override float GetAxis(string name, bool raw)
		{
			return 0f;
		}

		public override bool GetButton(string name)
		{
			return false;
		}

		public override bool GetButtonDown(string name)
		{
			return false;
		}

		public override bool GetButtonUp(string name)
		{
			return false;
		}

		public override void SetButtonDown(string name)
		{
		}

		public override void SetButtonUp(string name)
		{
		}

		public override void SetAxisPositive(string name)
		{
		}

		public override void SetAxisNegative(string name)
		{
		}

		public override void SetAxisZero(string name)
		{
		}

		public override void SetAxis(string name, float value)
		{
		}

		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}
	}
}
