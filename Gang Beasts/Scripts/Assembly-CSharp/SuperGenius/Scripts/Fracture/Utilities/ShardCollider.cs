using System;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.Utilities
{
	[Serializable]
	public class ShardCollider
	{
		[SerializeField]
		private ShardColliderType _shardColliderType;

		[SerializeField]
		private PhysicMaterial _physicMaterial;

		public void AddCollider(GameObject gameObject)
		{
		}

		private void AddBoxCollider(GameObject gameObject, PhysicMaterial physicMaterial)
		{
		}

		private void AddSphereCollider(GameObject gameObject, PhysicMaterial physicMaterial = null)
		{
		}

		private void AddMeshCollider(GameObject gameObject, bool convex, PhysicMaterial physicMaterial = null)
		{
		}
	}
}
