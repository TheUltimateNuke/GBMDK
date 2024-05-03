using System.Collections.Generic;
using UnityEngine.XR;

namespace GB.View
{
	public static class VRUtils
	{
		private static bool _vrChecked;

		private static bool _vrResult;

		public const float TRACKING_MULTIPLIER = 2f;

		public const string VRNameOculus = "Oculus";

		public const string VRNamePSVR = "PSVR";

		public const string VRModelRiftS = "rift s";

		private static List<InputDevice> _devices;

		public static void ConvertAllCanvases()
		{
		}

		public static bool IsVR()
		{
			return false;
		}

		private static bool CheckVR()
		{
			return false;
		}

		public static string GetVRDeviceType()
		{
			return null;
		}
	}
}
