using UnityEngine;

namespace GB.Game.Tool
{
	public class PhysicsVolumeBase : MonoBehaviour
	{
		[Header("General")]
		public PhysicsVolumeOverlap overlapType;

		public LayerMask TestMask;

		[Header("Sphere")]
		public float SphereRadius;

		[Header("Box")]
		public Vector3 Extents;

		[Header("Capsule")]
		public Vector3 point1;

		public Vector3 point2;

		public float CapsuleRadius;

		protected Rigidbody[] rigidbodies;

		public virtual int CastArea()
		{
			return 0;
		}

		public virtual void TriggerEffect()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
