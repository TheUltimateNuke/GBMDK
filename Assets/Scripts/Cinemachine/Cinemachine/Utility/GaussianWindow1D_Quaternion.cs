using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Quaternion : GaussianWindow1d<Quaternion>
	{
		public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override Quaternion Compute(int windowPos)
		{
			return default(Quaternion);
		}
	}
}
