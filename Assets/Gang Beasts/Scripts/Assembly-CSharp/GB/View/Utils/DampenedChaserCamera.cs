using UnityEngine;

namespace GB.View.Utils
{
	public class DampenedChaserCamera : MonoBehaviour
	{
		[SerializeField]
		private bool _vrOnly;

		[SerializeField]
		private Transform[] _target;

		private Transform _transformCache;

		[SerializeField]
		private Vector3 _offsetPosition;

		[SerializeField]
		private float _moveSpeed;

		[SerializeField]
		private float _rotationSpeed;

		[SerializeField]
		private float _offsetRotation;

		[SerializeField]
		private float _softZoneRotation;

		private void Awake()
		{
		}

		private float WantedRotation()
		{
			return 0f;
		}

		private Vector3 WantedPosition()
		{
			return default(Vector3);
		}

		private void LateUpdate()
		{
		}
	}
}
