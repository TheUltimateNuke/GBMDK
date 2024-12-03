using UnityEngine;

namespace Cinemachine.Utility
{
	public static class Damper
	{
		private const float Epsilon = 0.0001f;

		public const float kNegligibleResidual = 0.01f;

		private const float kLogNegligibleResidual = -4.6051702f;

		private static float DecayConstant(float time, float residual)
		{
			return 0f;
		}

		private static float DecayedRemainder(float initial, float decayConstant, float deltaTime)
		{
			return 0f;
		}

		public static float Damp(float initial, float dampTime, float deltaTime)
		{
			return 0f;
		}

		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime)
		{
			return default(Vector3);
		}
	}
}
