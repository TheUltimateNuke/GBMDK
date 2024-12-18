using UnityEngine;

namespace GB.View.Controllers
{
	public class PSVRViewController : ViewController
	{
		public bool ForceBlockVRGUIInput;

		private float platformForwardOffset;

		private GameObject _CameraObject;

		private static string CameraPrefabPath;

		public void Awake()
		{
		}

		public void LateUpdate()
		{
		}

		public override Vector3 GetForward()
		{
			return default(Vector3);
		}

		public override Vector3 GetUIPosition(float forwardMultiplier)
		{
			return default(Vector3);
		}

		public override Quaternion GetUIRotation()
		{
			return default(Quaternion);
		}

		protected override void AddEffects()
		{
		}

		protected override void AddGraphicalElement()
		{
		}

		protected override void SetGraphicsLimiters()
		{
		}

		private void UpdateVR()
		{
		}

		private void UpdateVRPosition()
		{
		}
	}
}
