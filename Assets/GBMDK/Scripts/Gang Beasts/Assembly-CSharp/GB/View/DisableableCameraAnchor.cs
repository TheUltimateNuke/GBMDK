using UnityEngine;

namespace GB.View
{
	public class DisableableCameraAnchor : CameraAnchor
	{
		[SerializeField]
		private CameraAnchor _fallthrough;

		[SerializeField]
		private CameraAnchor[] _fallbackPreviousAnchor;

		[SerializeField]
		private CameraAnchor[] _fallbackNextAnchor;

		public override CameraAnchor PreviousAnchor => null;

		public override CameraAnchor NextAnchor => null;

		private void OnDisable()
		{
		}
	}
}
