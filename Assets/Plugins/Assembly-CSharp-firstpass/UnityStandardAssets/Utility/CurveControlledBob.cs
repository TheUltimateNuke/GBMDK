using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class CurveControlledBob
	{
		public float HorizontalBobRange;

		public float VerticalBobRange;

		public AnimationCurve Bobcurve;

		public float VerticaltoHorizontalRatio;

		private float m_CyclePositionX;

		private float m_CyclePositionY;

		private float m_BobBaseInterval;

		private Vector3 m_OriginalCameraPosition;

		private float m_Time;

		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}
	}
}
