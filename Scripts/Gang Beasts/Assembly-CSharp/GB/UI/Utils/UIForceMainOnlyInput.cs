using UnityEngine;

namespace GB.UI.Utils
{
	public class UIForceMainOnlyInput : MonoBehaviour
	{
		private static int _activeForcers;

		private static int[] _beforeChange;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private static void PlatformEvents_OnLocalUserChanged(int slot, int localuserID, bool joined)
		{
		}

		private static void ForceMainInput()
		{
		}
	}
}
