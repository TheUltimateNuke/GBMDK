using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3>
	{
		public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override Vector3 Compute(int windowPos)
		{
			return default(Vector3);
		}
	}
}
