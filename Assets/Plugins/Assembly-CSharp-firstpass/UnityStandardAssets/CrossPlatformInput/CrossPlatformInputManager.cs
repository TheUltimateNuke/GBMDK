using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	public static class CrossPlatformInputManager
	{
		public enum ActiveInputMethod
		{
			Hardware = 0,
			Touch = 1
		}

		public class VirtualAxis
		{
			private float m_Value;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public float GetValue => 0f;

			public float GetValueRaw => 0f;

			public VirtualAxis(string name)
			{
			}

			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			public void Remove()
			{
			}

			public void Update(float value)
			{
			}
		}

		public class VirtualButton
		{
			private int m_LastPressedFrame;

			private int m_ReleasedFrame;

			private bool m_Pressed;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public bool GetButton => false;

			public bool GetButtonDown => false;

			public bool GetButtonUp => false;

			public VirtualButton(string name)
			{
			}

			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			public void Pressed()
			{
			}

			public void Released()
			{
			}

			public void Remove()
			{
			}
		}

		private static VirtualInput activeInput;

		private static VirtualInput s_TouchInput;

		private static VirtualInput s_HardwareInput;

		public static Vector3 mousePosition => default(Vector3);

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		static CrossPlatformInputManager()
		{
		}

		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		public static bool AxisExists(string name)
		{
			return false;
		}

		public static bool ButtonExists(string name)
		{
			return false;
		}

		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		public static void UnRegisterVirtualAxis(string name)
		{
		}

		public static void UnRegisterVirtualButton(string name)
		{
		}

		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		public static float GetAxis(string name)
		{
			return 0f;
		}

		public static float GetAxisRaw(string name)
		{
			return 0f;
		}

		private static float GetAxis(string name, bool raw)
		{
			return 0f;
		}

		public static bool GetButton(string name)
		{
			return false;
		}

		public static bool GetButtonDown(string name)
		{
			return false;
		}

		public static bool GetButtonUp(string name)
		{
			return false;
		}

		public static void SetButtonDown(string name)
		{
		}

		public static void SetButtonUp(string name)
		{
		}

		public static void SetAxisPositive(string name)
		{
		}

		public static void SetAxisNegative(string name)
		{
		}

		public static void SetAxisZero(string name)
		{
		}

		public static void SetAxis(string name, float value)
		{
		}

		public static void SetVirtualMousePositionX(float f)
		{
		}

		public static void SetVirtualMousePositionY(float f)
		{
		}

		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
}
