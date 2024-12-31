using UnityEngine;

namespace GB.Stages.Wheel
{
	public class PierBreakInfluence : MonoBehaviour
	{
		public float _effect;

		public float _minimumRange;

		public float _maximumRange;

		public AnimationCurve _effectCurve;

		private void OnDrawGizmos()
		{
		}

		public float GetEffectAtPosition(Vector3 position)
		{
			return 0f;
		}
	}
}
