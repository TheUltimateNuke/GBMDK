using UnityEngine;

namespace Cinemachine.Utility
{
	public class PositionPredictor
	{
		private Vector3 m_Velocity;

		private Vector3 m_SmoothDampVelocity;

		private Vector3 m_Pos;

		private bool m_HavePos;

		public float Smoothing;

		public bool IsEmpty()
		{
			return false;
		}

		public void ApplyTransformDelta(Vector3 positionDelta)
		{
		}

		public void Reset()
		{
		}

		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime)
		{
		}

		public Vector3 PredictPositionDelta(float lookaheadTime)
		{
			return default(Vector3);
		}

		public Vector3 PredictPosition(float lookaheadTime)
		{
			return default(Vector3);
		}
	}
}
