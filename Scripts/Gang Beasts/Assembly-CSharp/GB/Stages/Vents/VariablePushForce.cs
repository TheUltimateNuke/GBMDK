using UnityEngine;

namespace GB.Stages.Vents
{
	public class VariablePushForce : PushVolume
	{
		[SerializeField]
		private GameObject _forceCentre;

		private Transform _cachedFcT;

		[SerializeField]
		private GameObject _forceTip;

		[SerializeField]
		private float _minimumForceMagnitude;

		private float _cachedSqMaxDistance;

		private float _cachedForceMagnitude;

		protected override void Start()
		{
		}

		protected override void ApplyForce(Rigidbody rb, Transform t, PushVolumeClient client)
		{
		}
	}
}
