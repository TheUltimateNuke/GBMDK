using UnityEngine;

namespace GB.View.Controllers
{
	public class GlobalViewController : ViewController
	{
		private float platformForwardOffset;

		public override Vector3 GetForward()
		{
			return default(Vector3);
		}

		public override Vector3 GetUIPosition(float forwardOffset = 1.2f)
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
	}
}
