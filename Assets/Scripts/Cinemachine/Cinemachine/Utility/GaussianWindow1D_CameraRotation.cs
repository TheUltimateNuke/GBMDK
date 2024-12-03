using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<Vector2>
	{
		public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override Vector2 Compute(int windowPos)
		{
			return default(Vector2);
		}
	}
}
