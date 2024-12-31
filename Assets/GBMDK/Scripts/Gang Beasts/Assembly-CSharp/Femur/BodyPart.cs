using UnityEngine;

namespace Femur
{
	public class BodyPart
	{
		public Transform PartTransform;

		public Rigidbody PartRigidbody;

		public Collider PartCollider;

		public InteractableObjectData PartInteractable;

		public CollisionHandeler PartCollisionHandeler;

		public Renderer PartRenderer;

		public SimpleBuoyancy PartBuoyancy;

		public BodyPart(string transformName, Transform parent)
		{
		}

		public BodyPart(Transform transform, Transform parent)
		{
		}

		public void UnregisterCallbacks()
		{
		}

		public void ToggleRenderer()
		{
		}

		private void Setup(Transform transform, Transform parent)
		{
		}
	}
}
