using UnityEngine;

namespace GB.Game.Health
{
	public class CollisionDamageTaker : MonoBehaviour
	{
		[SerializeField]
		private HealthTracker _healthTracker;

		[SerializeField]
		private bool _serverOnly;

		[SerializeField]
		private float _defaultMass;

		[SerializeField]
		private bool _hasBody;

		[SerializeField]
		private Collider[] _body;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
