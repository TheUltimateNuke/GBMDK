using System.Collections.Generic;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.Components
{
	public class FractureShardEdgeGlue : MonoBehaviour
	{
		public LayerMask IgnoreLayer;

		private int _collisionCount;

		private int _fractureFrame;

		private RigidbodyConstraints _rigidBodyConstraints;

		private Vector3 _rigidBodyVelocity;

		private Vector3 _rigidBodyAngularVelocity;

		private Vector3 _impactPoint;

		private Vector3 _impactVelocity;

		private float _impactMass;

		private Rigidbody body;

		private List<Joint> addedJoints;

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}

		public void Init()
		{
		}
	}
}
