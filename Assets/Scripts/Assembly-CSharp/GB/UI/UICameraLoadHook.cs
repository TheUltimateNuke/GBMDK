using UnityEngine;

namespace GB.UI
{
	[RequireComponent(typeof(Camera))]
	public class UICameraLoadHook : MonoBehaviour
	{
		private Camera _localCameraRef;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void AlertHotLoad()
		{
		}

		private void OnLoadScreenShow()
		{
		}

		private void OnLoadScreenDismiss()
		{
		}
	}
}
