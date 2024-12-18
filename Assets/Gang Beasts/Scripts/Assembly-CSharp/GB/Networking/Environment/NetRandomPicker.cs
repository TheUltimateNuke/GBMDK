using UnityEngine;

namespace GB.Networking.Environment
{
	public class NetRandomPicker : MonoBehaviour
	{
		public NetRandomPickerTarget[] TargetObjects;

		public bool UseRandomKeepNum;

		public int NumObjectsToKeep;

		public int NumObjectsToKeepRandomMin;

		public int NumObjectsToKeepRandomMax;

		private void Start()
		{
		}
	}
}
